<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CHBYS.PRESENTATIONLAYER.login" %>



<!DOCTYPE html>
<html lang="tr">
<head runat="server">
    <title>Cari Hesap Bilgi Yönetim Sistemi</title>
    <link rel="shortcut icon" type="image/png" href="../icon.png">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!--===============================================================================================-->
    <link rel="icon" type="image/png" href="images/icons/favicon.ico" />
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/vendor/bootstrap/css/bootstrap.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/fonts/iconic/css/material-design-iconic-font.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/vendor/animate/animate.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/vendor/css-hamburgers/hamburgers.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/vendor/animsition/css/animsition.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/vendor/select2/select2.min.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/vendor/daterangepicker/daterangepicker.css">
    <!--===============================================================================================-->
    <link rel="stylesheet" type="text/css" href="userpanel/css/util.css">
    <link rel="stylesheet" type="text/css" href="userpanel/css/main.css">
    <!--===============================================================================================-->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container-login100" style="background-image: url('images/arkaplan5.jpg');">
                <div class="wrap-login100 p-l-55 p-r-55 p-t-80 p-b-30">
                    <form class="login100-form validate-form" action="../index.html">
                        <span class="login100-form-title p-b-37">Oturum Aç
                        </span>

                        <div class="wrap-input100 validate-input m-b-20" data-validate="E-Mail Giriniz">
                            <input class="input100" type="text" name="username" placeholder="E-Mail" runat="server" id="txtusername">
                            <span class="focus-input100"></span>
                        </div>

                        <div class="wrap-input100 validate-input m-b-25" data-validate="Parola Giriniz">
                            <input class="input100" type="password" name="pass" placeholder="Parola" runat="server" id="txtpassword">
                            <span class="focus-input100"></span>
                        </div>

                        <div class="container-login100-form-btn">
                            <asp:Button ID="btnlogin"  class="login100-form-btn" runat="server" Text="Giriş Yap" OnClick="btnlogin_Click" />
                        </div>

                        <div style="padding: 40px;" class="text-center p-t-57 p-b-20">
                            <span class="txt1">
                                <a href="uyekayit.aspx" class="txt1" style="text-decoration: none">Üye değil misiniz? Kaydol
                                </a>
                            </span>
                        </div>

                        <div class="text-center">
                            <a href="uyesifreunuttum.aspx" class="txt2 hov1">Şifremi Unuttum.
                            </a>
                        </div>
                    </form>


                </div>
            </div>

            <div id="dropDownSelect1"></div>
        </div>
    </form>
    <!--===============================================================================================-->
    <script src="vendor/jquery/jquery-3.2.1.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/animsition/js/animsition.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/bootstrap/js/popper.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/select2/select2.min.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/daterangepicker/moment.min.js"></script>
    <script src="vendor/daterangepicker/daterangepicker.js"></script>
    <!--===============================================================================================-->
    <script src="vendor/countdowntime/countdowntime.js"></script>
    <!--===============================================================================================-->
    <script src="js/main.js"></script>

</body>
</html>
