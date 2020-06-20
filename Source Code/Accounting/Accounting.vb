Module Accounting
    Public GlobalGLitemname As String = "if(a.level=0, a.itemname,if(a.level=1,concat('   ',a.itemname),if(a.level=2,concat('           ',a.itemname),if(a.level=3,concat('                  ',a.itemname),concat('                         ',a.itemname)))))"
End Module
