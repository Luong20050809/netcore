namespace Nvllesson06.Models
{
    public class NvlEmployee
    {
        public int NvlId { get; set; }              // Mã nhân viên 
        public string NvlName { get; set; }         // Họ tên
        public DateTime NvlBirthDay { get; set; }   // Ngày sinh
        public string NvlEmail { get; set; }        // Email
        public string NvlPhone { get; set; }        // Số điện thoại
        public decimal NvlSalary { get; set; }      // Lương
        public bool NvlStatus { get; set; }         // Trạng thái (true = đang làm việc, false = đang nghỉ việc)
    }
}
