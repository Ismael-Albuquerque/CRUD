function acesso(form) {

    /*Checa nome e senha - caso digite com letras maiúsculas será convertido para letras minúsculas */

    form.nome.value = form.nome.value.toLowerCase()
    form.senha.value = form.senha.value.toLowerCase()

    if (form.nome.value == "sma" && form.senha.value == "brasil2014") {

        location = "IndexAdm"
    }

    else {
        form.nome.value = ""
        form.senha.value = ""
        alert("Dados Incorretos")
    }

}