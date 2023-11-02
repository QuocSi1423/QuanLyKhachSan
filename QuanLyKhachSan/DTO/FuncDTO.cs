namespace QuanLyKhachSan.DTO
{
    public class FuncDTO
    {
        public int funcId { get; set; }
        public string funcName { get; set; }
        public FuncDTO() { }
        public FuncDTO(int funcId, string funcName)
        {
            this.funcId = funcId;
            this.funcName = funcName;
        }
    }
}