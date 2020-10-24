namespace Drakon.Domain.ProjectServices.ProjectChanges
{
    /// <summary>
    /// Simple change description.
    /// </summary>
    interface IProjectChange
    {
        /// <summary>
        /// Changed property name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Changed property value.
        /// </summary>
        object Value { get; set; }
    }
}
