﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Sarif;
using Microsoft.CodeAnalysis.Sarif.WorkItemFiling;
using Moq;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.UnitTests.Sarif.WorkItemFiling
{
    public class WorkItemFilerTests
    {
        private static readonly Uri s_testUri = new Uri("https://github.com/Microsoft/sarif-sdk");

        [Fact]
        public async void WorkItemFiler_ChecksProjectUriArgument()
        {
            var filer = CreateWorkItemFiler();

            Func<Task> action = async () => await filer.FileWorkItems(projectUri: null, workItemFilingModels: new List<WorkItemModel>()); ;

            await action.ShouldThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async void WorkItemFiler_ChecksWorkItemMetadataArgument()
        {
            var filer = CreateWorkItemFiler();

            Func<Task> action = async () => await filer.FileWorkItems(s_testUri, workItemFilingModels: null);

            await action.ShouldThrowAsync<ArgumentNullException>();
        }

        private static WorkItemFiler CreateWorkItemFiler()
            => new WorkItemFiler(CreateMockFilingTarget());

        private static FilingClient CreateMockFilingTarget()
        {
            var mockFilingTarget = new Mock<FilingClient>();

            mockFilingTarget
                .Setup(x => x.Connect(It.IsAny<string>()))
                .CallBase(); // The base class implementation does nothing, so this is safe.

            // Moq magic: you can return whatever was passed to a method by providing
            // a lambda (rather than a fixed value) to Returns or ReturnsAsync.
            // https://stackoverflow.com/questions/996602/returning-value-that-was-passed-into-a-method
            mockFilingTarget
                .Setup(x => x.FileWorkItems(It.IsAny<IEnumerable<WorkItemModel>>()))
                .ReturnsAsync((IEnumerable<WorkItemModel> resultGroups) => resultGroups);

            return mockFilingTarget.Object;
        }
    }
}