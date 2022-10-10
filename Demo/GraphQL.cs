using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class GuardianProfile
    {
        public string Name { get; set; }
    }
    
    public class Mutation
    {
        // Uncomment the below to observe returning a null GuardianProfile working
        // [UseMutationConvention(Disable = true)]
        public async Task<GuardianProfile> DeleteProfileAndRelationships()
        {
            return null;
        }
    }

    public class Query
    {
        public async Task<GuardianProfile> GetProfile()
        {
            return null;
        }
    }
}
