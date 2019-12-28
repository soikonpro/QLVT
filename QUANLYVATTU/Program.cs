using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;

namespace QUANLYVATTU
{
    static class Program
    {
        public static String server;
        public static String group;
        public static int manv;
        public static String loginName;
        public static String password;
        public static String connectionString;
        public static SqlConnection connection;
        public static String loginHienTai;
        public static String passwordHienTai;
        public static frmMain formMain;
        public static frmNhanvien formNhanvien;
        public static frmVattu formVattu;
        public static frmKho formKho;
        public static SubFormDDH SubFormDDH;
        public static SubFormCTDDH SubFormCTDDH;
        public static SubFormPN SubFormPN;
        public static SubFormCTPN SubFormCTPN;
        public static SubFormPX SubFormPX;
        public static SubFormCTPX SubFormCTPX;
        public static frmTaoTaiKhoan frmTaoTaiKhoan;
        public static BindingSource bindingSourceChiNhanh;  //Để khi đăng nhập vào biết Login từ Chi nhánh nào
        public static string remoteLogin = "HTKN";          //remote Default là vầy. Sử dụng khi đã vào 1 server con 
        public static string remotePassword = "123456";     //và muốn kết nối quá server con khác thông quá HTKN =))

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new frmLogin());
        }
    }
}
