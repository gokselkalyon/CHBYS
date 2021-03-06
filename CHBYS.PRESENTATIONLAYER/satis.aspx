﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PanelMaster.Master" AutoEventWireup="true" CodeBehind="satis.aspx.cs" Inherits="CHBYS.PRESENTATIONLAYER.satis" %>
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
                                            <li>Satışlar</li>
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
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış <i class="fas fa-angle-double-right" style="margin:10px;"></i> 1.Aşama</font></font></a>
                                    </li>
                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                       
                                                            <div class="mb-3">
                                                                <label for="country"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satılan Ürün</font></font></label>
                                                                
                                                                <asp:DropDownList ID="ddlsoldproduct1"  class="custom-select d-block w-100" runat="server"></asp:DropDownList>
                                                            </div>
                                                            <hr class="mb-4">
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Belge No</font></font></label>
                                                              <asp:TextBox type="text" runat="server" class="form-control" ID="txtBelgeno" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Tarih</font></font></label>
                                                              <asp:TextBox type="text" runat="server" class="form-control" ID="txtTarih" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Birim</font></font></label>
                    
                                                                    <asp:DropDownList ID="ddlcurrency"  class="custom-select d-block w-100" runat="server"></asp:DropDownList>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Araç</font></font></label>
                                                              
                                                                    <asp:DropDownList ID="ddlvechile"  class="custom-select d-block w-100" runat="server"></asp:DropDownList>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Ödeme Planı</font></font></label>
                                                              <asp:DropDownList ID="ddlpaymentplan" class="custom-select d-block w-100" runat="server"></asp:DropDownList>
                                                                </div>
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Maliyet</font></font></label>
                                                              <asp:TextBox type="text" runat="server" class="form-control" ID="txtcost" placeholder="" value=""></asp:TextBox>
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
                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                            <div class="section-block">
                                <h5 class="section-title"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></h5>
                                <p><font style="vertical-align: inherit;"><font style="vertical-align: inherit;"></font></font></p>
                            </div>
                            <div class="simple-card">
                                <ul class="nav nav-tabs nav-fill" id="myTab5" role="tablist">
                                    <li class="nav-item">
                                        <a class="nav-link active border-left-0" id="home-tab-simple" data-toggle="tab" href="#home-simple" role="tab" aria-controls="home" aria-selected="true"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış <i class="fas fa-angle-double-right" style="margin:10px;"></i> 2.Aşama</font></font></a>
                                    </li>
                                </ul>

                                <div class="tab-content" id="myTabContent5">
                                    <div class="tab-pane fade show active" id="home-simple" role="tabpanel" aria-labelledby="home-tab-simple">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="card">

                                                    <div class="card-body">
                                                       
                                                            
                                                            <div class="row">
                                                                <div class="col-md-6 mb-3">
                                                                    <label for="firstName"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Toplam Fiyat</font></font></label>
                                                              <asp:TextBox type="text" runat="server" class="form-control" ID="txttotalfiyat" placeholder="" value=""></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            
                                                       
                                                    </div>
                                                </div>
                                                <hr class="mb-4">
                                                <asp:Button ID="btnFaturakaydet" runat="server" Text="Faturayı Kaydet" class="btn btn-primary btn-lg btn-block" type="submit" OnClick="btnFaturakaydet_Click" />

                                            </div>

                                        </div>
                                    </div>

                                </div>

                            </div>

                        </div>
                        <div class="col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 mb-5">
                             <div class="row">
                             <div class="col-md-6 mb-3">
                             <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" class="btn btn-primary btn-lg btn-block " style="background-color:#167638;" type="submit" OnClick="btnGuncelle_Click" />
                             </div>
                                 <div class="col-md-6 mb-3">
                             <asp:Button ID="btnexcel" runat="server" Text="Excel'e aktar" class="btn btn-primary btn-lg btn-block " style="background-color:#167638;" type="submit" OnClick="btnexcel_Click" />
                             </div>
                             <div class="col-md-6 mb-3">
                             <asp:Button ID="btnsil" runat="server" Text="Sil" class="btn btn-primary btn-lg btn-block" style="background-color:#ab1919;" type="submit" OnClick="btnsil_Click" />
                             </div>
                             </div>
                        </div>

                    </div>
                    <div class="card">
                        <h5 class="card-header"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Satış Listesi</font></font></h5>
                        <div class="card-body" style="width:100%; overflow:auto;">
                            <asp:GridView ID="gvsoldproduct" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvsoldproduct_SelectedIndexChanged" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
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
                <asp:Label ID="dataid" runat="server" Text="" Visible="False"></asp:Label>
            </div>
            <!-- ============================================================== -->
            <!-- end footer -->
            <!-- ============================================================== -->
        </div>
        </form>
</asp:Content>
