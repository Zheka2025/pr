using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons2206.Engine
{
    class Enums
    {
        public enum PermissionRole
        {
            User = 1,
            Advanced_User,
            Moderator,
            Administrator,
            Owner
        }

        public enum StatusName
        {
            Success,
            FalseCreditional,
            Unexpected
        }
    }
}
