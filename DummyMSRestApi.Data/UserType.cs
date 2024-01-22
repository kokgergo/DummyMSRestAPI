using Microsoft.AspNetCore.Identity;

namespace DummyMSRestApi.Data
{
    public class UserType : IdentityUser
    { 
        public string displayName { get; set; }
        public virtual IList<LineData<TimeFields>> timeDatas { get; set; }
        public virtual IList<LineData<TypeFields>> typeDatas { get; set; }
    }
}