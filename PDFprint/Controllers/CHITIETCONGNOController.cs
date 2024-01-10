using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using PDFprint.Data;
using PDFprint.Models;
using PDFprint.Services;
using PDFprint.Services.Repository.IRepository;

namespace PDFprint.Controllers
{
    public class CHITIETCONGNOController : Controller
    {
        private readonly ICHITIETCONGNORepository _CHITIETCONGNORepo;
        private readonly ICONGNOTHEOTHANGRepository _CONGNOTHEOTHANGRepo;
        private readonly PdfGenerator _pdfGenerator;
        public CHITIETCONGNOController(ICHITIETCONGNORepository CHITIETCONGNOdb, ICONGNOTHEOTHANGRepository CONGNOTHEOTHANGdb, PdfGenerator pdfGenerator)
        {
            _CHITIETCONGNORepo= CHITIETCONGNOdb;
            _CONGNOTHEOTHANGRepo= CONGNOTHEOTHANGdb;
            _pdfGenerator = pdfGenerator;
        }
        public IActionResult CHITIET(string maKH,string month)
        {
            if (maKH != null && month != null)
            {

                CONGNOTHEOTHANG CONGNOTHEOTHANGObjs = _CONGNOTHEOTHANGRepo.getOneWithMaKHAndMonth(maKH, month);
                if (CONGNOTHEOTHANGObjs != null)
                {
                    List<CHITIETCONGNO> CHITIETCONGNOObjs = _CHITIETCONGNORepo.GetByCONGNOTHEOTHANGId(CONGNOTHEOTHANGObjs.id);
                    ViewBag.CONGNOTHEOTHANG = CONGNOTHEOTHANGObjs;
                    ViewBag.CHITIETCONGNO= CHITIETCONGNOObjs;
                }
            }
            return View();
        }
        public IActionResult PrintPDF(string maKH,string month)
        {
            string HtmlContent = "";
            if(maKH!=null && month != null)
            {

            CONGNOTHEOTHANG CONGNOTHEOTHANGObjs = _CONGNOTHEOTHANGRepo.getOneWithMaKHAndMonth(maKH, month);
            if (CONGNOTHEOTHANGObjs != null)
            {
                List<CHITIETCONGNO> CHITIETCONGNOObjs = _CHITIETCONGNORepo.GetByCONGNOTHEOTHANGId(CONGNOTHEOTHANGObjs.id);


                    HtmlContent = "" +
                       "<style>" +
                       ".headliner{" +
                       "position:relative;" +
                       "justify-content:space-between;" +
                       "}" +
                       ".headliner #left_header{" +
                       "text-align:left;" +
                       "float:left;position:absolute;left:0;" +
                       "}" +
                       ".headliner #right_header{" +
                       "text-align:right;" +
                       "float:right;position:absolute;right:0;" +
                       "}" +
                       ".form_title{" +
                       "text-align:center;padding-top:5rem;" +
                       "}" +
                       ".form_title div h5{" +
                       "text-align:center;" +
                       "}.form_title div h2{margin-bottom:0}" +
                       ".tb_CHITIETCONGNO table" +
                       "{" +
                       "border-collapse:collapse;" +
                       "justify-content:center;" +
                       "margin-top:3rem;" +
                       "}" +
                       ".tb_CHITIETCONGNO table thead tr td{" +
                       "border:1.5px black solid;" +
                       "text-align:center;" +
                       "font-weight:bold;" +
                       "}" +
                       ".tb_CHITIETCONGNO table thead tr  #chung_tu{" +
                       "text-align:center;" +
                       "}" +
                       ".tb_CHITIETCONGNO table thead tr  #dien_giai{" +
                       "width:50rem;text-align:center;" +
                       "}" +
                       ".tb_CHITIETCONGNO table thead tr  #phat_sinh_tang{" +
                       "width:20rem;" +
                       "}.tb_CHITIETCONGNO table thead tr  #phat_sinh_giam{" +
                       "width:20rem;" +
                       "}" +
                       ".tb_CHITIETCONGNO table thead tr  #ngay_ct{" +
                       "width:11rem;" +
                       "}" +
                       ".tb_CHITIETCONGNO table thead tr  #so_ct{" +
                       "width:11rem;" +
                       "}" +
                       ".tb_CHITIETCONGNO table tbody tr td{" +
                       "border:1.5px black solid;" +
                       "}" +
                       ".tb_CHITIETCONGNO table tbody tr td:nth-child(-n + 3){" +
                       "text-align:center;" +
                       "}" +
                       ".tb_CHITIETCONGNO table tbody tr td:nth-child(4){" +
                       "text-align:left;" +
                       "padding-left:0.5rem;" +
                       "}" +
                       ".tb_CHITIETCONGNO table tbody tr td:nth-last-child(-n + 2){" +
                       "text-align:right;" +
                       "padding-right:0.5rem" +
                       "}" +
                       ".tb_CHITIETCONGNO table tfoot tr td{" +
                       "border:1.5px black solid;" +
                       "font-weight:bold;" +
                       "}" +
                       ".CONGNOTHEOTHANG_summary" +
                       "{" +
                       "display: block;" +
                       "margin - top:0;}" +
                       ".CONGNOTHEOTHANG_summary h5{" +
                       "font-weight:bold;}" +
                       ".footer #date_time{" +
                       "text-align:right;" +
                       "padding-right:10rem;}" +
                       ".footer div{" +
                       "display:flex;" +
                       "justify-content:space-between;" +
                       "padding-left:2rem;" +
                       "padding-right:2rem;}" +
                       "</style>" +//end style
                       "<div class='container' style='font-size:20px;'>" +
                       "<div class='headliner'>" +
                       "<div id='left_header'>" +
                       "<h5 style='margin-bottom:0'> CÔNG TY TNHH SX HTD BÌNH TÂN</h5>" +
                       "<h5 style='margin-top:0;'>CN BITIS'S TẠI " + CONGNOTHEOTHANGObjs.ChiNhanh + "</h5>" +
                       "</div>" +
                       "<div id='right_header'>" +
                       "<h5 style='margin-bottom:0;'>Công Hòa xã hội chủ nghĩa Việt Nam</h5>" +
                       "<h5 style='text-align:center;margin-top:0;'>Độc lập - Tự do - Hạnh Phúc</h5>" +
                       "</div>" +
                       "</div>" +
                       "<div class='form_title'>" +
                       "<div>" +
                       "<h2 style='font-weight:bold;margin-bottom:0;'> BIÊN BẢN XÁC NHẬN CÔNG NỢ</h2>" +
                       "<h5 style='font-weight:bold;margin-top:0;'>Từ ngày: 01." + CONGNOTHEOTHANGObjs.Thang + "." + CONGNOTHEOTHANGObjs.Nam + " Đến ngày: 31." + CONGNOTHEOTHANGObjs.Thang + "." + CONGNOTHEOTHANGObjs.Nam + "</ h5 >" +
                       "</div>" +
                       "</div>" +
                       "<div class='customer_info'style='padding-left:5rem;' >" +
                       "<table style='font-weight:bold;'>" +
                       "<tr>" +
                       "<td style='width:10rem;'> Mã khách hàng</td>" +
                       "<td style='width:5rem;'>:</td>" +
                       "<td>" + CONGNOTHEOTHANGObjs.MaKhachHang + "</td>" +
                       "</tr><tr>" +
                       "<td>Tên khách hàng</td>" +
                       "<td>:</td>" +
                       "<td>" + CONGNOTHEOTHANGObjs.TenKhachHang + "</td>" +
                       "</tr><tr>" +
                       "<td>Địa chỉ</td>" +
                       "<td>:</td>" +
                       "<td>" + CONGNOTHEOTHANGObjs.DiaChi + "</td>" +
                       "</tr>" +
                       "<tr>" +
                       "<td>Tài Khoản</td>" +
                       "<td>:</td>" +
                       "<td>" + CONGNOTHEOTHANGObjs.TaiKhoan + "</td>" +
                       "</tr><tr>" +
                       "<td>Ngày khai trương</td>" +
                       "<td>:</td>" +
                       "<td>" + CONGNOTHEOTHANGObjs.NgayKhaiTruong + "</td>" +
                       "</tr>" +
                       "</table>" +
                       "</div>" +
                       "<div class= 'tb_CHITIETCONGNO' >" +
                       "<table>" +
                       "<thead style='text-align:center;font-weight:bold'>" +
                       "<tr>" +
                       "<td id='chung_tu' colspan = '2' > CHỨNG TỪ </td>" +
                       "<td id='kenh_pp'rowspan = '2' > KÊNH PP </td >" +
                       "<td id='dien_giai'rowspan = '2' > DIỄN GIẢI </td>" +
                       "<td id='phat_sinh_tang' rowspan = '2' > PHÁT SINH TĂNG</td>" +
                       "<td id='phat_sinh_giam' rowspan= '2' > PHÁT SINH GIẢM</td>" +
                       "</tr>" +
                       "<tr>" +
                       "<td id='ngay_ct'style='width:15rem;' > NGÀY CTỪ</td>" +
                       "<td id='so_ct' style='width:15rem;'> SỐ CTỪ</td>" +
                       "</tr>" +
                       "<tr>" +
                       "<td colspan='4' > CÔNG NỢ THÁNG TRƯỚC CHUYỂN SANG</td>" +
                       "<td style='text-align:right;padding-right:0.2rem'></td>" +
                       "<td style='text-align:right;padding-right:0.2rem''>" + ((CONGNOTHEOTHANGObjs.CongNoThangTruoc == null) ? "" : CONGNOTHEOTHANGObjs.CongNoThangTruoc) + "</td>" +
                       "</tr>" +
                       "</thead>" +
                       "<tbody>";
                    if (CHITIETCONGNOObjs != null)
                    {
                        CHITIETCONGNOObjs.ForEach(item =>
                        {
                            HtmlContent += "<tr>" +
                            "<td style='text-align:center;'>"+item.NGAYCHUNGTU+"</td>" +
                            "<td style='text-align:center;'>" + item.SOCHUNGTU + "</td>" +
                            "<td style='text-align:center;'>" + ((item.KENHPHANPHOI=="0")?"":item.KENHPHANPHOI) + "</td>" +
                            "<td style='text-align:left;padding-left:0.2rem'>" + item.DIENGIAI + "</td>" +
                            "<td style='text-align:right;padding-right:0.2rem'>" + ((item.PHATSINHTANG=="0")?"":item.PHATSINHTANG) + "</td>" +
                            "<td style='text-align:right;padding-right:0.2rem'>" + ((item.PHATSINHGIAM=="0")?"":item.PHATSINHGIAM) + "</td>" +
                            "</tr>";
                        });
                    }
                    else
                    {
                        HtmlContent += "";
                    }
                    
                    HtmlContent+="</tbody>" +
                    "<tfoot style='font-weight:bold;'>" +
                    "<tr>" +
                    "<td colspan='4' style='text-align:center;' > CỘNG SỐ PHÁT SINH TRONG THÁNG</td>" +
                    "<td style='text-align:right;padding-right:0.2rem'>"+CONGNOTHEOTHANGObjs.TongPhatSinhTang+"</td>" +
                    "<td style='text-align:right;padding-right:0.2rem'>"+CONGNOTHEOTHANGObjs.TongPhatSinhGiam+"</td>" +
                    "</tr>" +
                    "<tr>" +
                    "<td colspan='4'style='text-align:center;' > CỘNG NỢ CÒN LẠI CUỐI THÁNG</td>" +
                    "<td style='text-align:right;padding-right:0.2rem'>"+CONGNOTHEOTHANGObjs.CongNoConLai+"</td>" +
                    "<td style='text-align:right;padding-right:0.2rem'></td>" +
                    "</tr>" +
                    "</tfoot>" +
                    "</table>" +
                    "</div>" +
                    "<div class='CONGNOTHEOTHANG_summary'>" +
                    "<h5 style='margin-bottom:0;'>" +
                    "Tính đến ngày 31."+CONGNOTHEOTHANGObjs.Thang+"."+CONGNOTHEOTHANGObjs.Nam+" Khách hàng: "+CONGNOTHEOTHANGObjs.TenKhachHang+" còn nợ tại CN BITIS'S Tại "+CONGNOTHEOTHANGObjs.ChiNhanh+" số tiền là: " +
                    "</h5>" +
                    "<h5 style='margin-top:0;margin-bottom:0;'>" +
                    "Bằng số: "+CONGNOTHEOTHANGObjs.CongNoConLai+" VND" +
                    "</h5>" +
                    "<h5 style='margin-top:0;'>" +
                    "Bằng chữ: "+CONGNOTHEOTHANGObjs.CongNoConLaiTheoChu +
                    "</h5 >" +
                    "</div>" +
                    "<div class='footer' >" +
                    "<p id='date_time' > Ngày... tháng... năm.... </p>" +
                    "<div style='font-weight:bold;'>" +
                    "<table>" +
                    "<tr>" +
                    "<td style='width:20rem;text-align:center;'> Giám đốc </td>" +
                    "<td style='width:20rem;text-align:center;'> Người nhận </td>" +
                    "<td style='width:20rem;text-align:center;'> Kế toán </td>" +
                    "<td style='width:20rem;text-align:center;'> Nhân viên bán hàng</td>" +
                    "</tr>" +
                    "<tr>" +
                    "<td style='text-align:center;'>(Ký, ghi rõ họ tên)</td>" +
                    "<td style='text-align:center;'>(Ký, ghi rõ họ tên)</td>" +
                    "<td style='text-align:center;'>(Ký, ghi rõ họ tên)</td>" +
                    "<td style='text-align:center;'>(Ký, ghi rõ họ tên)</td>" +
                    "</tr>" +
                    "</div>" +
                    "</div>" +
                    "</div>" +
                    "</div>";
            }
            else
            {
                HtmlContent = "Something went wrong";
            }
            }
            else
            {
                HtmlContent = "MaKH or month = null";
            }

            byte[] pdfBytes = _pdfGenerator.GeneratorPdf(HtmlContent);

            return File(pdfBytes,"application/pdf","CONGNOTHEOTHANG.pdf");
        }
    }
}
