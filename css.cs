*{
	-webkit-box-sizing: border-box;
	-moz-transition-box-sizing: border-box;
	box-sizing: border-box;
}

body{
	font-family: Arial, Helvetica, sans-serif;
	font-size: 1em;
}

.formulario_{
    display:block;
	position: fixed;
	top: 0;
	right: 0;
	left: 0;
	bottom: 0;
}

.formulario_> div {
	width: 350px;
	margin: 1% auto;
	padding-bottom: 20px;
	border-radius: 10px;
	background: #fff;
	padding-bottom: 10px;
}

.input_div{
	padding: 10px;
	display: flex;
}

#title{
	text-align: center;
	width: 100%;
	height: 40px;
	border-radius:  5px 5px 0px 0px;
	display: flex;
}

#title-form {
	font-family: 'Oswald', sans-serif;
    font-size: 24px;
    color: #232323;
    background-color: #FAFAFA;
    margin: 35px auto;
}
.container-form {
	margin-top: 40px;
}

#input_form {
	border: solid #232323;
	border-radius: 5px;
	border-width: 1px;
	display: block;
	width: 100%;
	height: 35px;
	padding: 5px;
	font-family: 'Oswald', sans-serif;
    font-size: 15px;
}

.send-buttons {
	display: flex;
	justify-content: center;
	text-align: center;
	margin: 20px 80px;
	border: solid #232323;
    border-radius: 5px;
    border-width: 1px;
    width: 180px;
    padding: 5px;
    font-family: 'Oswald', sans-serif;
    font-size: 15px;
    background-color: #232323;
    color:  #FAFAFA;
}

.send-buttons:hover {
	background-color: #FAFAFA;
	color: #232323;
}

#input-form:focus{
	border: 1px solid #00BFFF;
}

.close {
    color: #232323;
    text-decoration: none;
    font-weight: bold;
    font-size: 20px;
    display: inline-flex;
    z-index: 1;
    float: right;
    margin-top: 5px;
    margin-right: 5px;
}
.close .fa-times-circle {
	color: #232323;
}

.close:hover .close:focus {
    color: #000;
    text-decoration: none;
    cursor: pointer;
}
