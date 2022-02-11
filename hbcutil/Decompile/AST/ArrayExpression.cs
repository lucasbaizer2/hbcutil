﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HbcUtil.Decompile.AST {
    public class ArrayExpression : ISyntax {
        public List<ISyntax> Elements { get; set; }

        public ArrayExpression() {
            Elements = new List<ISyntax>();
        }

        public void Write(SourceCodeBuilder builder) {
            builder.Write("[");
            for (int i = 0; i < Elements.Count; i++) {
                Elements[i].Write(builder);
                if (i < Elements.Count - 1) {
                    builder.Write(", ");
                }
            }
            builder.Write("]");
        }
    }
}
