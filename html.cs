<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <link rel="stylesheet" href="../../assets/css/exemplo.css">
        <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
        <link href="https://fonts.googleapis.com/css?family=Oswald:200" rel="stylesheet">
        <title>Usuários</title>
    </head>
    <body>
        <div class="container-table">
            <div class="content">
                <div id="formulario" class="formulario">
                    <div>
                        <form action="createUser.php" method="post">
                            <div id="title">
                                <h1 id="title-form">Cadastro de novo Usuário</h1>
                                <a class="close"><i class="fa fa-times-circle" aria-hidden="true"></i></a>
                            </div>
                            <div class="container-form">
                                <div class="input_div">
                                    <input class="input_form" type="text" name="name" placeholder="Digite seu Nome"
                                    value="" required>
                                </div>
                                <div class="input_div">
                                    <input class="input_form" type="text" name="email" placeholder="Digite seu Email"
                                    value="" required>
                                </div>
                                <div class="input_div">
                                    <input class="input_form" type="text" name="login" placeholder="Digite seu Login"
                                    value="" required>
                                </div>
                                <div class="input_div">
                                    <input class="input_form" type="password" name="password" placeholder="Digite sua Senha" required>
                                </div>
                                 <div class="input_div">
                                    <input class="input_form" type="text" name="telefone" placeholder="Digite seu Telefone"
                                    value="" required>
                                </div>
                                 <div class="input_div">
                                    <input class="input_form" type="text" name="city" placeholder="Digite sua Cidade"
                                    value="" required>
                                </div>
                                 <div class="input_div">
                                    <input class="input_form" type="text" name="state" placeholder="Digite seu Estado"
                                    value="" required>
                                </div>
                                 <div class="input_div">
                                    Sexo:
                                    <input type="radio" name="masc"
                                    value="Masculino" required> Masculino
                                    <input type="radio" name="fem"
                                    value="Feminino" required> Feminino
                                </div>
                            </div>
                            <button class="send-buttons" name="action" value="create"> enviar </button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html
