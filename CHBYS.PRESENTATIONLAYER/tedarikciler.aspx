<%@ Page Title="" Language="C#" MasterPageFile="~/PanelMaster.Master" AutoEventWireup="true" CodeBehind="tedarikciler.aspx.cs" Inherits="CHBYS.PRESENTATIONLAYER.tedarikciler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">  
    <div class="dashboard-wrapper">
            <div class="dashboard-ecommerce">
                <div class="container-fluid dashboard-content ">
                    <!-- ============================================================== -->
                    <!-- pageheader  -->
                    <!-- ============================================================== -->
                    <div class="row">
                        <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12">
                            <div class="page-header">
                                <h2 class="pageheader-title">Cari Hesap Bilgi Yönetim Sistemi</h2>
                                <div class="page-breadcrumb">
                                    <nav aria-label="breadcrumb">
                                        <ol class="breadcrumb">
                                            <li class="breadcrumb-item"><a href="#" class="breadcrumb-link">İşlem Menüsü</a></li>
                                            &nbsp;
                                            <li style="margin:3px;" class="fas fa-angle-right"></li> &nbsp;
                                            <li>Tedarikçiler</li>
                                        </ol>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <h5 class="card-header"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tedarikçiler Listesi</font></font></h5>
                        <div class="card-body">
                            <table class="table table-striped">
                                <thead>
                                    <tr>
                                        <th scope="col"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">#</font></font></th>
                                        <th scope="col"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">İlk</font></font></th>
                                        <th scope="col"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Son</font></font></th>
                                        <th scope="col"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Sap</font></font></th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <th scope="row"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">1</font></font></th>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">işaret</font></font></td>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Otto</font></font></td>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">@mdo</font></font></td>
                                    </tr>
                                    <tr>
                                        <th scope="row"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">2</font></font></th>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Jacob</font></font></td>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Thornton</font></font></td>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">@şişman</font></font></td>
                                    </tr>
                                    <tr>
                                        <th scope="row"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">3</font></font></th>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Larry</font></font></td>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">kuş</font></font></td>
                                        <td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">@twitter</font></font></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <h2 class="pageheader-title">Sisteme Yeni Tedarikçi Ekle</h2>
                    <div class="page-breadcrumb">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item"><a href="#" class="breadcrumb-link">İşlem Menüsü</a></li>
                                &nbsp;
                                <li style="margin:3px;" class="fas fa-angle-right"></li> &nbsp;
                                <li>Tedarikçi Ekleme & İşlem Bilgileri</li>
                            </ol>
                           
                        </nav>
                    </div>

                    <div class="row">
                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                            <div class="section-block">
                                <h5 class="section-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></h5>
                                <p><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></p>
                            </div>
                            <div class="simple-card">
                                <ul class="nav nav-tabs nav-fill" id="myTab5" role="tablist">
                                    <li class="nav-item">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kimlik Bilgileri</font></font></a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" id="contact-tab-simple" data-toggle="tab" href="#contact-simple" role="tab" aria-controls="contact" aria-selected="false"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Cari</font></font></a>
                                    </li>
                                    <li class="nav-item">
                                        <a class="nav-link" id="profile-tab-simple" data-toggle="tab" href="#profile-simple" role="tab" aria-controls="profile" aria-selected="false"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">İletişim</font></font></a>
                                    </li>
                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">İsmi / Unvanı</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAdunvan" placeholder="" value=""></asp:TextBox>

                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Resim</font></font></label>
                                                                    <asp:FileUpload ID="Fileresim" runat="server"  type="file" style="width:220px; padding:3px; " />
                                                                </div>
                                                            </div>

                                                        </form>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="tab-pane fade" id="profile-simple" role="tabpanel" aria-labelledby="profile-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">E-Posta</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtMail" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Yetkili Kişi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtYetkilikisi" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="username"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Cep Telefonu</font></font></label>
                                                                <div class="input-group">
                                                                    <div class="input-group-prepend">
                                                                        <span class="input-group-text"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">TR</font></font></span>
                                                                    </div>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtTelefon" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="address"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Adres</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAdres" placeholder="" value=""></asp:TextBox>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="cc-name"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Diğer Erişim Bilgileri</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtErisimbilgileri" placeholder="" value=""></asp:TextBox>
                                                                <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Sabit Telefon, Faks vb</font></font></small>
                                                            </div>

                                                            <hr class="mb-4">
                                                            <asp:Button ID="btnKaydet" runat="server" Text="Bilgileri Kaydet" class="btn btn-primary btn-lg btn-block" type="submit" />

                                                        </form>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="tab-pane fade" id="contact-simple" role="tabpanel" aria-labelledby="contact-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Vergi Dairesi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtVergidairesi" placeholder="" value=""></asp:TextBox>
                                                                    <div class="invalid-feedback">
                                                                        Valid first name is required.
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Müşteri Para Birimi</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="txtParabirimi">
                                                                       <option value="">TR</option>
                                                                        <option>USD</option>
                                                                        <option>EUR</option>
                                                                        <option>GBP</option>
                                                                        <option>CHF</option>
                                                                        <option>AZN</option>
                                                                        <option>MKD</option>
                                                                        <option>TMT</option>
                                                                        <option>GEL</option>
                                                                        <option>RUB</option>
                                                                    </select>
                                                                    <div class="invalid-feedback">
                                                                        Please select a valid country.
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Vergi / TC Kimlik No</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtVergitcno" placeholder="" value=""></asp:TextBox>

                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Açık Hesap Risk Limiti</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAcikhesaprisklimiti" placeholder="" value=""></asp:TextBox>

                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Vadesi (gün)</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtVadesi" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Banka Bilgileri</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtBankabilgileri" placeholder="" value=""></asp:TextBox>
                                                                    <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tedarikçinin banka bilgilerini girebilirsiniz.</font></font></small>
                                                                </div>  
                                                            </div>
                                                            <div>
                                                                <asp:CheckBox ID="checkboxVergimuaf"  runat="server" /><label>&nbsp;&nbsp;Vergiden Muaf mı?</label>
                                                            </div>                                      
                                                        </form>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                      


                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                            <div class="section-block">
                                <h5 class="section-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></h5>
                                <p><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></p>
                            </div>
                            <div class="simple-card">
                                <ul class="nav nav-tabs nav-fill" id="myTab5" role="tablist">
                                    <li class="nav-item" border-bottom-color:white;">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tedarikçi İşlem Bilgileri</font></font></a>
                                    </li>

                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Açık Bakiyesi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAcikbakiyesi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Çek Bakiyesi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtCekbakiyesi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="address"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Senet Bakiyesi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtSenetbakiyesi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                            </div>
                                                            <hr class="mb-4">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" class="btn btn-primary btn-lg btn-block " style="background-color:#167638;" type="submit" />
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                <asp:Button ID="btnsil" runat="server" Text="Sil" class="btn btn-primary btn-lg btn-block" style="background-color:#ab1919;" type="submit" />
                                                                </div>
                                                            </div>
                                                        </form>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- footer -->
            <!-- ============================================================== -->
            <div class="footer">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12">
                            Copyright © 2019 Tüm Hakları Saklıdır. <a href="https://colorlib.com/wp/">Cari Hesapla</a>.
                        </div>
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12 col-12">
                            <div class="text-md-right footer-links d-none d-sm-block">
                                <a href="javascript: void(0);">Hakkımızda</a>
                                <a href="javascript: void(0);">Destek</a>
                                <a href="javascript: void(0);">İletişim</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- ============================================================== -->
            <!-- end footer -->
            <!-- ============================================================== -->
        </div>
         </form>
</asp:Content>
