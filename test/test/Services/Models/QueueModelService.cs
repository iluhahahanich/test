﻿using System.Collections.Generic;

namespace test.Services
{
    public class QueueModelService
    {
        public int Id { get; set; }
        public string TeacherId { get; set; }
        public string OuthorId { get; set; }
        public List<string> UsersId { get; set; }
        public List<int> UsersPriority { get; set; }
    }


}