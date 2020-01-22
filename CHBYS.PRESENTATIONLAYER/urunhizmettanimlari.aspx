<%@ Page Title="" Language="C#" MasterPageFile="~/PanelMaster.Master" AutoEventWireup="true" CodeBehind="urunhizmettanimlari.aspx.cs" Inherits="CHBYS.PRESENTATIONLAYER.urunhizmettanimlari" %>
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
                                            <li>Ürünler</li>
                                        </ol>
                                    </nav>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="card">
                        <h5 class="card-header"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürünler Listesi</font></font></h5>
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
                    <h2 class="pageheader-title">Sisteme Yeni Ürün/Hizmet Ekle</h2>
                    <div class="page-breadcrumb">
                        <nav aria-label="breadcrumb">
                            <ol class="breadcrumb">
                                <li class="breadcrumb-item"><a href="#" class="breadcrumb-link">İşlem Menüsü</a></li>
                                &nbsp;
                                <li style="margin:3px;" class="fas fa-angle-right"></li> &nbsp;
                                <li>Ürün/Hizmet Ekleme & İşlem Bilgileri</li>
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
                                    <li class="nav-item" style="width:185px;">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün / Hizmet Tanımı</font></font></a>
                                    </li>
                                    <li class="nav-item" style="width:120px;">
                                        <a class="nav-link" id="contact-tab-simple" data-toggle="tab" href="#contact-simple" role="tab" aria-controls="contact" aria-selected="false"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Fiyatlandırma</font></font></a>
                                    </li>
                                    <li class="nav-item" style="width:140px;">
                                        <a class="nav-link" id="profile-tab-simple" data-toggle="tab" href="#profile-simple" role="tab" aria-controls="profile" aria-selected="false"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Diğer Bilgiler</font></font></a>
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
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün Adı</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtUrunad" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış Birimi</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="selectedSatisbirimi" required="">
                                                                       <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Adet</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ay</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Bağ</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Bidon</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Boy</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Cc<font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Cilt</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Çift</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Çuval</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Dakika</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Dekar</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Desi</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Dilim</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Dönem</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Düzine</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Galon</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Gram</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Gross</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Grup</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Gün</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Karat</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kasa</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kavanoz</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kilogram</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kilometre</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Koçan</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Koli</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kova</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kutu</font></font></option>

                                                                    </select>

                                                                    <div class="invalid-feedback">
                                                                        Please select a valid country.
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün Tipi</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="selectedUruntipi" required="">
                                                                         <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Stoklu Ürün</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Stoksuz Ürün (hizmet)</font></font></option>
                                                                    </select>
                                                                </div>
                                                                <div style="margin:35px;">
                                                                <asp:CheckBox ID="checkboxEticareturunu"  runat="server" /><label>&nbsp;&nbsp;E-Tiracet Ürünü Mü?</label>
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
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kategori</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtKategori" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün Barkod</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtUrunbarkod" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Marka</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtMarka" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Stok Takibi</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="selectedStoktakibi" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Normal stok takibi</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Seri no ile takip</font></font></option>
                                                                    </select>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün Kodu</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtUrunkodu" placeholder="Var ise ürün kodunu giriniz." value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Kritik Stok Miktarı (Adet)</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtKritikstokmiktari" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Fatura Başlığı</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtFaturabasligi" placeholder="" value=""></asp:TextBox>
                                                                    <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Dilerseniz fatura çıktısında farklı bir ürün adı kullanabilirsiniz.</font></font></small>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="lastName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Etiketler</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtEtiketler" placeholder="" value=""></asp:TextBox>
                                                                    <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Etiketleri ürün arama yaparken kullanabilirsiniz.</font></font></small>

                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="cc-name"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Açıklama</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAciklama" placeholder="İsteğe bağlı not girebilirsiniz." value=""></asp:TextBox>
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
                                                                    <label for="username"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış Fiyatı</font></font></label>
                                                                    <div class="input-group">
                                                                        <div class="input-group-prepend">
                                                                            <select class="custom-select d-block w-100" ID="selectedSatisfiyati" required="">
                                                                                <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">TR</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">USD</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">EUR</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">GBP</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">CHF</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">AZN<font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">MKD</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">TMT</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">GEL</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">RUB</font></font></option>
                                                                            </select>
                                                                        </div>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtSatisfiyati" placeholder="" value=""></asp:TextBox>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="username"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış Fiyatı</font></font></label>
                                                                    <div class="input-group">
                                                                        <div class="input-group-prepend">
                                                                            <select class="custom-select d-block w-100" id="selectedalisfiyati" required="">
                                                                                <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">TR</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">USD</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">EUR</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">GBP</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">CHF</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">AZN<font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">MKD</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">TMT</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">GEL</font></font></option>
                                                                                <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">RUB</font></font></option>
                                                                            </select>
                                                                        </div>
                                                                        <input type="text" class="form-control" ID="txtAlisfiyati" placeholder="" required="">
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış KDV Oranı (%)</font></font></label>
                                                                    <select class="custom-select d-block w-100" ID="selectedsatiskdvorani" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">0</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">27</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">23</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">21</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">20</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">19<font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">18</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">16</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">13</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">12</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">10</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">9</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">8</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">7</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">6</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">5</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">4</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">1</font></font></option>

                                                                    </select>
                                                                    <div class="invalid-feedback">
                                                                        Please select a valid country.
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış KDV Oranı (%)</font></font></label>
                                                                    <select class="custom-select d-block w-100" ID="selectedaliskdvorani" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">0</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">27</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">23</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">21</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">20</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">19<font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">18</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">16</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">13</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">12</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">10</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">9</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">8</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">7</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">6</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">5</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">4</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">1</font></font></option>
                                                                    </select>

                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış Fiyatına KDV Dahil mi?</font></font></label>
                                                                    <select class="custom-select d-block w-100" ID="selectedsatisfiyatinadahilmi" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">KDV hariç</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">KDV dahil</font></font></option>
                                                                    </select>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış Fiyatına KDV Dahil mi?</font></font></label>
                                                                    <select class="custom-select d-block w-100" ID="selectedalisfiyatinadahilmi" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">KDV hariç</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">KDV dahil</font></font></option>
                                                                    </select>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ö.İ.V. Oranı (%)</font></font></label>
                                                                    <select class="custom-select d-block w-100" ID="selectedoivorani" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ö.İ.V. yok</font></font></option>
                                                                        <option><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">% 7,50</font></font></option>
                                                                    </select>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış İskontosu (%)</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAlisiskontasu" placeholder="" value=""></asp:TextBox>

                                                                    <div class="invalid-feedback">
                                                                        Please select a valid country.
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ö.T.V Tipi</font></font></label>
                                                                    <select class="custom-select d-block w-100" ID="selectedotvtipi" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ö.T.V. yok</font></font></option>
                                                                    </select>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış ÖTV Oranı (%)</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAlisotvorani" placeholder="" value=""></asp:TextBox>
                                                                    <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Özel Tüketim Vergisi.</font></font></small>
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
                                    <li class="nav-item" border-bottom-color:white;">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün İşlem Bilgileri</font></font></a>
                                    </li>

                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="" style="margin:8px;">

                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış Fiyatı</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAlisfiyatibilgisi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış Fiyatı</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtSatisfiyatibilgisi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Toplam Stok</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtToplamstokbilgisi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Stok Değeri</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtStokdegeribilgisi" placeholder="0.00TL" ReadOnly="true" value=""></asp:TextBox>
                                                                </div>
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
