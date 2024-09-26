using System;
using System.Collections.Generic;

namespace THWedB1.Model;

public partial class THangSx
{
    public string MaHangSx { get; set; } = null!;

    public string? HangSx { get; set; }

    public string? MaNuocThuongHieu { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; set; } = new List<TDanhMucSp>();
}
