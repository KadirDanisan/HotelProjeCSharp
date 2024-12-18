﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelProject.EntityLayers.Concrete
{
    public class Room
    {
        public int RoomId { get; set; } 
        public string RoomNmber { get; set; }
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title {  get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
