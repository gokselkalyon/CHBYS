﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PanelMaster.Master" AutoEventWireup="true" CodeBehind="alis.aspx.cs" Inherits="CHBYS.PRESENTATIONLAYER.alis" %>
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
                                            <li>Alışlar</li>
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
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış <i class="fas fa-angle-double-right" style="margin:10px;"></i> 1.Aşama</font></font></a>
                                    </li>
                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="">
                                                            <div class="mb-3">
                                                                <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tedarikçiyi Bulun</font></font></label>
                                                                <select class="custom-select d-block w-100" id="selectedTedarikciyibulun" required="">
                                                                    <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Veritabanındaki Tedarikçi Seçilir.</font></font></option>
                                                                </select>
                                                                <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış yaptığınız tedarikçiyi bulun</font></font></small>
                                                            </div>
                                                            <hr class="mb-4">
                                                            <asp:Button ID="btnTedarikçigetir" runat="server" Text="Tedarikçi Getir" class="btn btn-primary btn-lg btn-block" type="submit" />
                                                            <hr class="mb-4">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Belge No</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtBelgeno" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tarih</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtTarih" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Masraf Kalemi</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="selectedMasrafkalemi" required="">
                                                                        <option></option>
                                                                        <option>Bakım/Onarım</option>
                                                                        <option>Ceza</option>
                                                                        <option>Kasko/Sigorta</option>
                                                                        <option>Kiralama</option>
                                                                        <option>Vergi</option>
                                                                        <option>Yakıt</option>
                                                                        <option>Aidat</option>
                                                                        <option>Kira</option>
                                                                        <option>Elektrik</option>
                                                                        <option>Isınma</option>
                                                                        <option>İletişim</option>
                                                                        <option>Kırtasiye</option>
                                                                        <option>Su</option>
                                                                        <option>Temizlik</option>
                                                                        <option>Banka Masrafları</option>
                                                                        <option>Stopaj</option>
                                                                        <option>Noter</option>
                                                                        <option>Mali Müşavir</option>
                                                                        <option>Kurumlar Vergisi</option>
                                                                        <option>Kur Farkı</option>
                                                                        <option>Faiz</option>
                                                                        <option>Kdv</option>
                                                                        <option>Maaş</option>
                                                                        <option>Prim</option>
                                                                        <option>Tazminat</option>
                                                                        <option>Ulaşım</option>
                                                                        <option>Vegi/SSK</option>
                                                                        <option>Yemek</option>
                                                                    </select>              
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Vadesi</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtVadesi" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Sevk No</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtSevkno" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Açıklama</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtAciklama" value=""></asp:TextBox>
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
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alış <i class="fas fa-angle-double-right" style="margin:10px;"></i> 2.Aşama</font></font></a>
                                    </li>
                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                        <form class="needs-validation" novalidate="">
                                                            <div class="mb-3">
                                                                <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ürün Seçin</font></font></label>
                                                                <select class="custom-select d-block w-100" id="selectedUrunsecin" required="">
                                                                    <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Veritabanındaki Ürün Seçilir.</font></font></option>
                                                                </select>
                                                                <small class="text-muted"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satışı yapılacak olan ürün seçilir.</font></font></small>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Miktar (ad)</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtMiktar" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Depo Seçin</font></font></label>
                                                                    <select class="custom-select d-block w-100" id="selectedDeposecin" required="">
                                                                        <option value=""><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Veritabanındaki Depo Seçilir.</font></font></option>
                                                                    </select>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Fiyat</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtFiyat" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Toplam Fiyat</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtToplamfiyat" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="mb-3">
                                                                <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Açıklama girin</font></font></label>
                                                                    <asp:TextBox type="text" runat="server" class="form-control" ID="txtFaturaaçıklama" Placeholder="İsteğe bağlı" value=""></asp:TextBox>
                                                            </div>
                                                        </form>
                                                    </div>
                                                </div>
                                                <hr class="mb-4">
                                                <asp:Button ID="btnFaturakaydet" runat="server" Text="Faturayı Kaydet" class="btn btn-primary btn-lg btn-block" type="submit" />

                                            </div>

                                        </div>
                                    </div>

                                </div>

                            </div>

                        </div>
                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                                 <div class="row">
                                     <div class="col-md-6 mb-3">
                                        <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" class="btn btn-primary btn-lg btn-block " style="background-color:#167638;" type="submit" />
                                     </div>
                                     <div class="col-md-6 mb-3">
                                     <asp:Button ID="btnsil" runat="server" Text="Sil" class="btn btn-primary btn-lg btn-block" style="background-color:#ab1919;" type="submit" />
                                    </div>
                                </div>
                        </div>
                    </div>
                    <div class="card">
                        <h5 class="card-header"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Alınan Ürünler Listesi</font></font></h5>
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
