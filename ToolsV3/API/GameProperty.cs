﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsV3.API
{
    public class GameProperty
    {
        public string Description { get; }
        public string Value { get; }

        public GameProperty(string description, string value)
        {
            this.Description = description;
            this.Value = value;
        }
    }
}
