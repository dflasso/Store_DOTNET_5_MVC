using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class UserProfile
    {
        public int UserProfileId {get; set;}
        public int UserAppId { get; set; }
        public int ProfileId {get; set;}
        public DateTime AssignmentAt {get; set;}
        public DateTime ModifiedAt {get; set;}
        public DateTime ExpiresAt {get; set;}
        public string Observations {get; set;}

         public UserProfile(int userProfileId, int userAppId, int profileId, DateTime assignmentAt, DateTime modifiedAt, string observations)
        {
            UserProfileId = userProfileId;
            UserAppId = userAppId;
            ProfileId = profileId;
            AssignmentAt = assignmentAt;
            ModifiedAt = modifiedAt;
            Observations = observations;
        }

        public UserProfile(int userProfileId, int userAppId, int profileId, DateTime assignmentAt, DateTime modifiedAt, DateTime expiresAt, string observations)
        {
            UserProfileId = userProfileId;
            UserAppId = userAppId;
            ProfileId = profileId;
            AssignmentAt = assignmentAt;
            ModifiedAt = modifiedAt;
            ExpiresAt = expiresAt;
            Observations = observations;
        }

        public UserProfile()
        {
        }
    }
}