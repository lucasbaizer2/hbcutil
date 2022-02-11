﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HbcUtil.Decompile.AST;

namespace HbcUtil.Decompile {
    public class FunctionState {
        public ISyntax[] Registers { get; set; }

        public FunctionState(uint registers) {
            Registers = new ISyntax[registers];
        }

        public void DebugPrint() {
            for(int i = 0; i < Registers.Length; i++) {
                Console.Write($"Register {i}: ");
                if (Registers[i] == null) {
                    Console.WriteLine("empty");
                } else {
                    SourceCodeBuilder builder = new SourceCodeBuilder("    ");
                    Registers[i].Write(builder);
                    Console.WriteLine(builder.ToString());
                }
            }
        }
    }
}
