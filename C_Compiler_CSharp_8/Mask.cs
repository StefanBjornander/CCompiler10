namespace CCompiler {
  public enum Mask {StorageMask = 0x0000FFF,
                    Auto        = 0x0000010,
                    Register    = 0x0000020,
                    Static      = 0x0000040,
                    Extern      = 0x0000080,
                    Typedef     = 0x0000100,

                    QualifierMask = 0x000F000,
                    Constant      = 0x0001000,
                    Volatile      = 0x0002000,

                    SortMask  = 0xFFF0000,
                    Signed    = 0x0010000,
                    Unsigned  = 0x0020000,
                    Char      = 0x0040000,
                    Short     = 0x0100000,
                    Int       = 0x0200000,
                    Long      = 0x0400000,
                    Float     = 0x0800000,
                    Double    = 0x1000000,
                    Void      = 0x2000000,

                    SignedChar = Signed | Char,
                    UnsignedChar = Unsigned |  Char,
                    ShortInt = Short |  Int,
                    SignedShort = Signed |  Short,
                    SignedShortInt = Signed |  Short |  Int,
                    UnsignedShort = Unsigned |  Short,
                    UnsignedShortInt = Unsigned |  Short |  Int,
                    SignedInt = Signed |  Int,
                    UnsignedInt = Unsigned |  Int,
                    LongInt = Long |  Int,
                    SignedLong = Signed |  Long,
                    SignedLongInt = Signed |  Long |  Int,
                    UnsignedLong = Unsigned |  Long,
                    UnsignedLongInt = Unsigned |  Long |  Int,
                    LongDouble = Long |  Double};
}
