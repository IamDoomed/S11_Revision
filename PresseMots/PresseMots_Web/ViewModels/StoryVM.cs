using System.Collections.Generic;
using PresseMots.Models;

namespace PresseMots.ViewModels
{
    public class StoryVM
    {

        public Story Story { get; set; }
        public List<Story> Stories { get; set; } = new List<Story>();

        public int WordCount { get; set; }
        public string StoryTitle { get; set; }
        public string ShortStory { get; set; }
        public int StoryId { get; set; }

    }
}
