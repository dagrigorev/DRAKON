using Drakon.Data.Program;

using System.Collections.Generic;
using System.ComponentModel;

namespace Drakon.Data.Project
{
    /// <summary>
    /// Project container contract.
    /// </summary>
    public interface IProjectContainer
    {
        /// <summary>
        /// Project name.
        /// </summary>
        [Description("Project name")]
        string ProjectName { get; set; }

        /// <summary>
        /// DRAKON programs collection that included in project.
        /// </summary>
        [Description("Programs")]
        ISet<IProgram> ProgramsCollection { get; }
    }
}
