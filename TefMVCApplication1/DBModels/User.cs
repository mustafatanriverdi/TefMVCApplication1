using System;
using System.Collections.Generic;

namespace TefMVCApplication1.DBModels;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Province { get; set; } = null!;
}
