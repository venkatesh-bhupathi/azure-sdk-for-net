// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Result for a single task added as part of an add task collection
    /// operation.
    /// </summary>
    public partial class TaskAddResult
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddResult class.
        /// </summary>
        public TaskAddResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskAddResult class.
        /// </summary>
        /// <param name="status">The status of the add task request.</param>
        /// <param name="taskId">The ID of the task for which this is the
        /// result.</param>
        /// <param name="eTag">The ETag of the task, if the task was
        /// successfully added.</param>
        /// <param name="lastModified">The last modified time of the
        /// task.</param>
        /// <param name="location">The URL of the task, if the task was
        /// successfully added.</param>
        /// <param name="error">The error encountered while attempting to add
        /// the task.</param>
        public TaskAddResult(TaskAddStatus status, string taskId, string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), string location = default(string), BatchError error = default(BatchError))
        {
            Status = status;
            TaskId = taskId;
            ETag = eTag;
            LastModified = lastModified;
            Location = location;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the add task request.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'success', 'clientError', 'serverError'
        /// </remarks>
        [JsonProperty(PropertyName = "status")]
        public TaskAddStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the ID of the task for which this is the result.
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the task, if the task was successfully
        /// added.
        /// </summary>
        /// <remarks>
        /// You can use this to detect whether the task has changed between
        /// requests. In particular, you can be pass the ETag with an Update
        /// Task request to specify that your changes should take effect only
        /// if nobody else has modified the job in the meantime.
        /// </remarks>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the task.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the URL of the task, if the task was successfully
        /// added.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the error encountered while attempting to add the
        /// task.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public BatchError Error { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TaskId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaskId");
            }
        }
    }
}
