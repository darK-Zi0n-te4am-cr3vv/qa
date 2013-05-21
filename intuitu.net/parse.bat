@echo off

mkdir parsed

.\bin\parser http://www.intuitu.net/category/Kategorii-slovarei/Protokoly-bezopasnogo-setevogo-vzaimodeistviYa > .\parsed\Protokoly-bezopasnogo-setevogo-vzaimodeistviYa.md
.\bin\parser http://www.intuitu.net/category/Kategorii-slovarej/Kriptograficheskie-osnovy-bezopasnosti > .\parsed\Kriptograficheskie-osnovy-bezopasnosti.md
.\bin\parser http://www.intuitu.net/category/Kategorii-slovarej/Osnovy-informatsionnoj-bezopasnosti > .\parsed\Osnovy-informatsionnoj-bezopasnosti.md
