﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.BasicacModels
{
    [Serializable]
    public class UserAchievement
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public int AchievementId { get; set; }

        public virtual User User { get; set; }
        public virtual Achievement Achievement { get; set; }    
    }
}
