Funcionalidade: Usuário - Cadastro
	Como um visitante da loja
	Eu desejo me cadastrar como usuário
	Para que eu possa realizar compras na loja

Cenário: Cadastro de usuário com sucesso
Dado Que o visitante está acessando o site da loja
Quando Ele clicar em registrar
E Preencher os dados do formulario
		| Dados                |
		| E-mail               |
		| Senha                |
		| Confirmação da Senha |
E Clicar no botão registrar
Então Ele será redirecionado para a vitrine
E Uma saudação com seu e-mail será exibida no menu superior

Cenário: Cadastro com senha sem maiusculas
Dado Que o visitante está acessando o site da loja
Quando Ele clicar em registrar
E Preencher os dados do formulario com uma senha sem maiusculas
		| Dados                |
		| E-mail               |
		| Senha                |
		| Confirmação de senha |
E Clicar no botão registrar
Então Ele receberá uma mensagem de erro que a senha precisa conter uma letra maiuscula

Cenário: Cadastro com senha sem caractere especial
Dado Que o visitante está acessando o site da loja
Quando Ele clicar em registrar
E Preencher os dados do formulario com uma senha sem caractere especial
		| Dados                |
		| E-mail               |
		| Senha                |
		| Confirmação de senha |
E Clicar no botão registrar
Então Ele receberá uma mensagem de erro que a senha precisa conter um caractere especial
