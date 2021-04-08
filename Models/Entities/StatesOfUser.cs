using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class StatesOfUser
    {
        public StatesOfUser()
        {
        }

        public StatesOfUser(int statesOfUserId, DateTime createAt, DateTime modifiedAt, string observations, int userAppId, int statesId)
        {
            StatesOfUserId = statesOfUserId;
            CreateAt = createAt;
            ModifiedAt = modifiedAt;
            this.observations = observations;
            UserAppId = userAppId;
            this.userApp = userApp;
            StatesId = statesId;
            this.state = state;
        }

        public StatesOfUser( DateTime createAt, DateTime modifiedAt, string observations, int userAppId,int statesId)
        {
            CreateAt = createAt;
            ModifiedAt = modifiedAt;
            this.observations = observations;
            UserAppId = userAppId;
            this.userApp = userApp;
            StatesId = statesId;
            this.state = state;
        }

        public int StatesOfUserId {get; set;}
        public DateTime CreateAt {get; set;}
        public DateTime ModifiedAt {get; set;}
        public string observations {get; set;}
        public int UserAppId { get; set; }
        public UserApp userApp {get; set;}
        public int StatesId {get; set;}
        public States state {get; set;}
    }
}