using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace INTEX.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalProjects { get; set; }
        public int ProjectsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) Math.Ceiling((double)TotalProjects/ProjectsPerPage);
    }
}
