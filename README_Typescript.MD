### Course of TypeScript (Complete) on Udemy.

I'm doing a big-revision now and a complete course of Typescript based on this course on Udemy: <br>
https://www.udemy.com/course/curso-de-javascript-moderno-do-basico-ao-avancado/
https://github.com/luizomf/cursojstypescript

It has an **entire part** for Typescript with about 25h of course, so I'll do it. The instructor will also explain another
stuff like OOP, SOLID, Design Patterns and everything. So Yeah, it will be also a big big "another" big-review.<br><br>

This course will be storage on **Typescript** folder. Also inside "doc" folder you'll find documentation and the github
source for it. In this file I'll keep all documentation around it. The course is separated by the instructor on 11 parts,
so inside this README I'll also break-down the annotattions into 11 parts. Make sense isn't it?<br>

### 1 - Installation: ----------------------------------------------------------------------------------------------------
npm init -y (starts the project and creates the package.json)
npm i typescript -D

**Compilation**:
To Compile a File in TERMINAL:
npx tsc index.ts
npx tsc (compile all files)
npx tsc --help (show all commands)
npx tsc -w (To Watch the Folder and change in files (hot-reload))

To use CODERUNNER and click on "RUN" to compile and run a file (note: needs to install CodeRunner BunHan Extension):
npm i ts-node -D (this will enable code-runner and a easy way to compile and run my TS files - see IMG2)

(note: the best way is WEBPACK but we will see it in next classes)

**EsLint** (note: needs to install ESLint extension - Dirk Baeumer, create eslintrc.js - see IMG3):
npm i eslint -D
npm i @typescript-eslint/eslint-plugin @typescript-eslint/parser -D

**Pretier** (see IMG4):
npm i prettier eslint-config-prettier eslint-plugin-prettier -D

**tsconfig.json** (will create a config file for my typescript env) (see IMG5):
npx tsc --init (will create the tsconfig.json)

### 2- BaseTypes: --------------------------------------------------------------------------------------------------------
All Files are on Folder 2_TiposBasicos inside SRC.

**WebPack**: You'll use WebPack to generate webapps and more: bundles, to unity your project and generate a final project.
First of all you need to go to WebPack website to get the config files and generate bundles:

npm i ts-loader webpack webpack-cli -D
(see the configuration of webpack on project by IMG2 on folder 2)

npx webpack (compilate)
npx webpack -w (watch the files)

Note: On folder Doc > 2_TiposBasicos you also have DOCUMENTATION about the config of WebPack - from IMG2 to 7.

**Exercise**:
On the final of the module I made an exercise of VALIDATION FORM. So I've created a folder called "exercicio-formcontrol"
inside the src folder, and I've updated the webpack.config.js to point to entry of this file "exercicio.ts".

npm i validator
npm i @types/validator

### 3- Classes Interfaces POO: -------------------------------------------------------------------------------------------

**Note**: Some classes of OOP course he's designing some DIAGRAMS on "yEd live". It's a tool (nice one) to print diagrams
on the screen. This Tool generates a PNG and also a export/import file in "graphml" extension. I'm saving those extensions
in the respective folders, so you can see the print, and also open the tool and re-generate the original diagram.

**Dependency Inversion**: See IMG2 on the folder 03. It explain beautifuly!

### 4- Advanced Types: ---------------------------------------------------------------------------------------------------

### 5- Generics: ---------------------------------------------------------------------------------------------------------

### 6- Decorators: -------------------------------------------------------------------------------------------------------

### 7- Namespaces and Modules: -------------------------------------------------------------------------------------------

### 8- SOLID: ------------------------------------------------------------------------------------------------------------

### 9- Tests with Jest: --------------------------------------------------------------------------------------------------

### 10- TypeScript and React: --------------------------------------------------------------------------------------------

### 11- Design Patterns: --------------------------------------------------------------------------------------------------




