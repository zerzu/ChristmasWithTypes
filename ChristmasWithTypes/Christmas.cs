using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable
                                             //COMPLETE Eric Garner 9/27/2023 1316
                                             //TODO Make the property, "Day", type enum
        public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

    }
}
