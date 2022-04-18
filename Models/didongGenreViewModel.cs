using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace cuahangdidong.Models

{
    public class didongGenreViewModel
    {

        public List<didong>? didong { get; set; }
        public SelectList? Genre { get; set; }
        public string? didongThểLoại { get; set; }
        public string? SearchString { get; set; }
        public SelectList ThểLoại { get; internal set; }
    }
}