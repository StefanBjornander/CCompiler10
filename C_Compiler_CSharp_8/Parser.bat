﻿@echo
@C:
@cd "C:\Users\stefa\Documents\A A C_Compiler_CSharp_10\C_Compiler_CSharp_8"

@"C:\gppg-distro-1_5_2\binaries\Gppg" /gplex MainParser.gppg > MainParser.cs
@"C:\gppg-distro-1_5_2\binaries\Gplex" MainScanner.gplex

@"C:\gppg-distro-1_5_2\binaries\Gppg" /gplex PreParser.gppg > PreParser.cs
@"C:\gppg-distro-1_5_2\binaries\Gplex" PreScanner.gplex

@"C:\gppg-distro-1_5_2\binaries\Gppg" /gplex ExpressionParser.gppg > ExpressionParser.cs
@"C:\gppg-distro-1_5_2\binaries\Gplex" ExpressionScanner.gplex

@cd "C:\Users\stefa\Documents\A A C_Compiler_CSharp_10\Calculator_CS_8"
@"C:\gppg-distro-1_5_2\binaries\Gppg" /gplex Parser.gppg > Parser.cs
@"C:\gppg-distro-1_5_2\binaries\Gplex" Scanner.gplex

@pause