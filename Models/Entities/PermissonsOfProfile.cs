using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class PermissonsOfProfile
    {
        public int PermissonsOfProfileId {get; set;}
        public DateTime AssignmentAt {get; set;}
        public DateTime ModifiedAt {get; set;}
        public int PermissionsId {get; set;}
        public int ProfileId {get; set;}

        public PermissonsOfProfile(int permissonsOfProfileId, DateTime assignmentAt, DateTime modifiedAt, int permissionsId, int profileId)
        {
            PermissonsOfProfileId = permissonsOfProfileId;
            AssignmentAt = assignmentAt;
            ModifiedAt = modifiedAt;
            PermissionsId = permissionsId;
            ProfileId = profileId;
        }

        public PermissonsOfProfile()
        {
        }
    }
}