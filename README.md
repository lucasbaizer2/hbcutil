# hbcutil

hbcutil is a utility for working with [Hermes](https://github.com/facebook/hermes) bytecode.

hbcutil can disassemble bytecode of any Hermes version into a human and machine-readable format called Hasm.

hbcutil can compile Hasm files into Hermes bytecode files (versions 40-86), allowing you to edit the disassembly of a Hermes file and assemble your changes, allowing modifications to Hermes bytecode.

hbcutil also has a very WIP decompiler.

# Using

// TODO guide on how to use the command line

# Directory Structure

The `bytecode-format-generator` directory contains a Node.js script, used for scraping the Hermes git repository for modifications to Hermes bytecode, and parsing the changes made.
This is used for generating definition files for prior versions, as well as new ones.

The `hbcutil` directory contains the Visual Studio C# project for the actual code of the application.

The `hasm-vscode` directory contains the source for the Visual Studio Code extension for working with Hasm assembly.

See each subproject's README for more detailed information:
* [bytecode-format-generator](./bytecode-format-generator/README.md)
* [hbcutil](./hbcutil/README.md)
* [hasm-vscode](./hasm-vscode/README.md)

# License

See the [LICENSE](LICENSE) file.
