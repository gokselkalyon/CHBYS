<%@ Page Title="" Language="C#" MasterPageFile="~/PanelMaster.Master" AutoEventWireup="true" CodeBehind="hesaplarim.aspx.cs" Inherits="CHBYS.PRESENTATIONLAYER.hesaplarim" %>
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
                                            <li>Hesaplarım</li>
                                        </ol>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--Veri Tablosu-->
                    <div class="row">
                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                            <div class="section-block">
                                <h5 class="section-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></h5>
                                <p><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></p>
                            </div>
                            <div class="simple-card">
                                <ul class="nav nav-tabs nav-fill" id="myTab5" role="tablist">
                                    <li class="nav-item">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Hesaplarım <i class="fas fa-angle-double-right" style="margin:10px;"></i> 1.Aşama</font></font></a>
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
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Hesap Seç</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="selectedHesapsec" required="">
                                                                        <option>Kasa</option>
                                                                        <option>Pos Hesabı</option>
                                                                        <option>Kredi Kartım</option>
                                                                    </select>
                                                                    </div>
                                                                    <div class="col-md-6 mb-3">
                                                                        <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">KASA</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtKasa" Placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                    </div>
                                                            </div>
                                                          
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tutar</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtTutar" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">İşlem Tarihi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtIslemtarihi" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Açıklama</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAciklama" value=""></asp:TextBox>
                                                            </div>
                                                            <hr class="mb-4">
                                                 <div class="row">
                                                    <div class="col-md-6 mb-3">
                                                    <asp:Button ID="btnHesabaparagirisi" runat="server" Text="Hesaba Para Girişi Yap" class="btn btn-primary btn-lg btn-block " style="background-color:#167638;" type="submit" />
                                                  </div>
                                                    <div class="col-md-6 mb-3">
                                                    <asp:Button ID="btnHesaptanparacikisi" runat="server" Text="Hesaptan Para Çıkışı Yap" class="btn btn-primary btn-lg btn-block" style="background-color:#ab1919;" type="submit" />
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
                       
                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                            <div class="section-block">
                                <h5 class="section-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></h5>
                                <p><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></p>
                            </div>
                            <div class="simple-card">
                                <ul class="nav nav-tabs nav-fill" id="myTab5" role="tablist">
                                    <li class="nav-item">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Hesaplarım <i class="fas fa-angle-double-right" style="margin:10px;"></i> 2.Aşama</font></font></a>
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
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Hesap Adı</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtHesapadi" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Hesap No</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtHesapno" value=""></asp:TextBox>
                                                                    <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">İsteğe Bağlı</font></font></small>
                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Güncel Bakiye</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtGuncelbakiye" value=""></asp:TextBox>
                                                            </div>
                                                            <hr class="mb-4">
                                                            <div class="row">
                                                    <div class="col-md-6 mb-3">
                                                    <asp:Button ID="btnbilgileriguncelle" runat="server" Text="Bilgileri Güncelle" class="btn btn-primary btn-lg btn-block " style="background-color:#167638;" type="submit" />
                                                  </div>
                                                    <div class="col-md-6 mb-3">
                                                <asp:Button ID="btnYenihesapekle" runat="server" Text="Yeni Hesap Ekle" class="btn btn-primary btn-lg btn-block" type="submit" />
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
                    <div class="card">
                        <h5 class="card-header"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Hesap Hareketleri</font></font></h5>
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
