using System;


namespace R5T.L0086
{
    public class ProjectNames : IProjectNames
    {
        #region Infrastructure

        public static IProjectNames Instance { get; } = new ProjectNames();


        private ProjectNames()
        {
        }

        #endregion
    }
}
