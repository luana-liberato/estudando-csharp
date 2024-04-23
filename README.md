<div Align="center">

  # Estudando C#
  Esse repositório tem como objetivo formar uma documentação própria da linguagem C# para posterior consulta e possivelmente colaborar com o aprendizado de outras pessoas.

  #### :construction:  Documentação em construção  :construction:

  ![Lê-se c sharp](/imagens/csharp.png)

</div>

# Vamos conhecer C#! :nerd_face:
C# é uma linguagem de programação desenvolvida pela Microsoft como parte da plataforma .NET, uma plataforma de desenvolvimento multilinguagem na qual ofere um ambiente de desenvolvimento, execução e gerenciamento de aplicações e serviços para diversos dispositivos e sistemas operacionais.

Agora, sobre o C#, visto que ela faz parte da plataforma .NET, ela permite que uma mesma aplicação seja executada em diversos positivos diferentes. Em sua essência se trata de uma linguagem que dá suporte ao paradigma de orientação à objetos. Ela é utilizada para o desenvolvimento de softwares simples até os mais robustos, podendo criar aplicações web, mobile e games.

## Características da linguagem de programação C# :mechanical_arm:
- `Fortemente tipada`: Os tipos definidos da linguagem precisam ser especificados em variáveis e funções. Estas definições são importantes para uma linguagem fortemente tipada e permite um maior controle do código.

- `Orientada a Objetos e Orientada a Componentes`: Ela dá suporte aos conceitos de orientação a objetos, sendo está a sua essência, e também, permite o reuso de componentes de software.

- `Linguagem de programação multiparadigma`: Apesar de em sua essência ser uma linguagem orientada a objetos, ela também dá suporte aos paradigma estruturado, funcional e assíncrono.

- `Interoperabilidade`: Ela possui capacidade de interagir com outras linguagens e tecnologias do sistema ampliando sua capacidade.

- `Multiplataforma`: Ela permite que uma mesma aplicação seja executada em diversos dispositivos diferentes.

## Como funciona o processo de execução do código fonte? :thinking:
Todo código fonte escrito em C# utiliza o conceito de máquina virtual que para o caso de C# é a CLR (Common Language Runtime), um tipo de computador virtual que vai gerenciar todos os programas .NET, ou seja, a CLR é um ambiente de execução para todas as linguagens aceitas.

O processo é simples. O código fonte passa por um compilador próprio da linguagem que gera o mesmo código em uma nova linguagem conhecida como linguagem intermediária: a CIL (Common Intermediate Language). Essa linguagem é uma padronização entendida pela nossa máquina virtual CLR que recebendo esse código em linguagem intermediária vai então compilar unsando o compilador JIT (Just in Time) que converte o arquivo por fim em código de máquina para ser executado.

Um detalhe importante, na primeira compilação do código fonte C# os arquivos gerados são empacotados fisicamente em assemblies. Os assemblies normalmente têm a extensão de arquivo .exe quando implementamos programas ou .dll quando implementamos bibliotecas.

<div Align="center">

  ![Compilação de programas C#](/imagens/compilacao.png)

</div>
