namespace Contract.DTO.Admin
{
    public class RoomResidencyChangedDTO
    {
        public string RoomSpatialID { get; set; } = string.Empty;
        public string PreviousState { get; set; } = string.Empty;
        public string NewState { get; set; } = string.Empty;
    }

    public class UserConnectionChangedDTO
    {
        public string UserID { get; set; } = string.Empty;
        public int ActiveConnectionCount { get; set; }
    }

    public class UserSessionChangedDTO
    {
        public string UserID { get; set; } = string.Empty;
        public string? PlayerInstanceID { get; set; } = string.Empty;
    }
}