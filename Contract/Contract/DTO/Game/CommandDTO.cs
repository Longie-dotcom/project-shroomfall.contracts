using Contract.DTO.Common;

namespace Contract.DTO.Game
{
    public class MoveDTO
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    public class ChatDTO
    {

    }

    public class UpdatePlayerAppearanceDTO
    {
        public string SkinID { get; set; } = string.Empty;
        public HSVDTO SkinColor { get; set; } = new HSVDTO();
        public string HairID { get; set; } = string.Empty;
        public string EyesID { get; set; } = string.Empty;
        public string ShirtID { get; set; } = string.Empty;
        public string PantID { get; set; } = string.Empty;
        public HSVDTO HairColor { get; set; } = new HSVDTO();
        public HSVDTO PantColor { get; set; } = new HSVDTO();
    }

    public class UseItemDTO
    {
        public string ItemInstanceID { get; set; } = string.Empty;
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
    }
}