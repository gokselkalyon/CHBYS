using CHBYS.BUSINESSLAYER.Respository.concreteclass;
using CHBYS.ENTITIES;
using CHBYS.ENTITIES.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CHBYS.WCFSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void authorization_code_insert(c_authorization_code t);

        [OperationContract]
        void authorization_code_update(c_authorization_code t);
        [OperationContract]
        List<V_authorization_code> authorization_code_Read();

        //[OperationContract]
        //V_authorization_code authorization_code_FilterRead(Expression<Func<V_authorization_code, bool>> filtre);

        [OperationContract]
        void authorization_code_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void authorization_code_type_insert(c_authorization_code_type t);

        [OperationContract]
        void authorization_code_type_update(c_authorization_code_type t);
        [OperationContract]
        List<V_authorization_code_type> authorization_code_type_Read();

        //[OperationContract]
        //V_authorization_code_type authorization_code_type_FilterRead(Expression<Func<V_authorization_code_type, bool>> filtre);

        [OperationContract]
        void authorization_code_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void bank_insert(c_bank t);

        [OperationContract]
        void bank_update(c_bank t);
        [OperationContract]
        List<V_bank> bank_Read();

        //[OperationContract]
        //V_bank bank_FilterRead(Expression<Func<V_bank, bool>> filtre);

        [OperationContract]
        void bank_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void barcode_insert(c_barcode t);

        [OperationContract]
        void barcode_update(c_barcode t);
        [OperationContract]
        List<V_barcode> barcode_Read();

        //[OperationContract]
        //V_barcode barcode_FilterRead(Expression<Func<V_barcode, bool>> filtre);

        [OperationContract]
        void barcode_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void brand_insert(c_brand t);

        [OperationContract]
        void brand_update(c_brand t);
        [OperationContract]
        List<V_brand> brand_Read();

        //[OperationContract]
        //V_brand brand_FilterRead(Expression<Func<V_brand, bool>> filtre);

        [OperationContract]
        void brand_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void cargo_company_insert(c_cargo_company t);

        [OperationContract]
        void cargo_company_update(c_cargo_company t);
        [OperationContract]
        List<V_cargo_company> cargo_company_Read();

        //[OperationContract]
        //V_cargo_company cargo_company_FilterRead(Expression<Func<V_cargo_company, bool>> filtre);

        [OperationContract]
        void cargo_company_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void cargo_company_name_insert(c_cargo_company_name t);

        [OperationContract]
        void cargo_company_name_update(c_cargo_company_name t);
        [OperationContract]
        List<V_cargo_company_name> cargo_company_name_Read();

        //[OperationContract]
        //V_cargo_company_name cargo_company_name_FilterRead(Expression<Func<V_cargo_company_name, bool>> filtre);

        [OperationContract]
        void cargo_company_name_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void city_insert(c_city t);

        [OperationContract]
        void city_update(c_city t);
        [OperationContract]
        List<V_city> city_Read();

        //[OperationContract]
        //V_city city_FilterRead(Expression<Func<V_city, bool>> filtre);

        [OperationContract]
        void city_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void company_insert(c_company t);

        [OperationContract]
        void company_update(c_company t);
        [OperationContract]
        List<V_company> company_Read();

        //[OperationContract]
        //V_company company_FilterRead(Expression<Func<V_company, bool>> filtre);

        [OperationContract]
        void company_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void company_type_insert(c_company_type t);

        [OperationContract]
        void company_type_update(c_company_type t);
        //[OperationContract]
        //void company_type_Read();

        //[OperationContract]
        //void company_type_FilterRead(Expression<Func< bool>> filtre);

        [OperationContract]
        void company_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void country_insert(c_country t);

        [OperationContract]
        void country_update(c_country t);
        [OperationContract]
        List<V_country> country_Read();

        //[OperationContract]
        //V_country country_FilterRead(Expression<Func<V_country, bool>> filtre);

        [OperationContract]
        void country_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void county_insert(c_county t);

        [OperationContract]
        void county_update(c_county t);
        [OperationContract]
        List<V_county> county_Read();

        //[OperationContract]
        //V_county county_FilterRead(Expression<Func<V_county, bool>> filtre);

        [OperationContract]
        void county_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void currency_insert(c_currency t);

        [OperationContract]
        void currency_update(c_currency t);
        [OperationContract]
        List<V_currency> currency_Read();

        //[OperationContract]
        //V_currency currency_FilterRead(Expression<Func<V_currency, bool>> filtre);

        [OperationContract]
        void currency_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void discountcart_insert(c_discountcart t);

        [OperationContract]
        void discountcart_update(c_discountcart t);
        [OperationContract]
        List<V_discountcart> discountcart_Read();

        //[OperationContract]
        //V_discountcart discountcart_FilterRead(Expression<Func<V_discountcart, bool>> filtre);

        [OperationContract]
        void discountcart_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void E_invoice_type_insert(c_E_invoice_type t);

        [OperationContract]
        void E_invoice_type_update(c_E_invoice_type t);
        [OperationContract]
        List<V_E_invoice_type> E_invoice_type_Read();

        //[OperationContract]
        //V_E_invoice_type E_invoice_type_FilterRead(Expression<Func<V_E_invoice_type, bool>> filtre);

        [OperationContract]
        void E_invoice_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void e_waybill_insert(c_e_waybill t);

        [OperationContract]
        void e_waybill_update(c_e_waybill t);
        [OperationContract]
        List<V_e_waybill> e_waybill_Read();

        //[OperationContract]
        //V_e_waybill e_waybill_FilterRead(Expression<Func<V_e_waybill, bool>> filtre);

        [OperationContract]
        void e_waybill_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void employee_insert(c_employee t);

        [OperationContract]
        void employee_update(c_employee t);
        [OperationContract]
        List<V_employees> employee_Read();

        //[OperationContract]
        //V_employees employee_FilterRead(Expression<Func<V_employees, bool>> filtre);

        [OperationContract]
        void employee_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void employee_overtime_insert(c_employee_overtime t);

        [OperationContract]
        void employee_overtime_update(c_employee_overtime t);
        [OperationContract]
        List<V_employee_overtime> employee_overtime_Read();

        //[OperationContract]
        //V_employee_overtime employee_overtime_FilterRead(Expression<Func<V_employee_overtime, bool>> filtre);

        [OperationContract]
        void employee_overtime_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void employee_permission_insert(c_employee_permission t);

        [OperationContract]
        void employee_permission_update(c_employee_permission t);
        [OperationContract]
        List<V_employee_permission> employee_permission_Read();

        //[OperationContract]
        //V_employee_permission employee_permission_FilterRead(Expression<Func<V_employee_permission, bool>> filtre);

        [OperationContract]
        void employee_permission_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void employee_position_insert(c_employee_position t);

        [OperationContract]
        void employee_position_update(c_employee_position t);
        [OperationContract]
        List<V_employee_position> employee_position_Read();

        //[OperationContract]
        //V_employee_position employee_position_FilterRead(Expression<Func<V_employee_position, bool>> filtre);

        [OperationContract]
        void employee_position_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void group_code_insert(c_group_code t);

        [OperationContract]
        void group_code_update(c_group_code t);
        [OperationContract]
        List<V_group_code> group_code_Read();

        //[OperationContract]
        //V_group_code group_code_FilterRead(Expression<Func<V_group_code, bool>> filtre);

        [OperationContract]
        void group_code_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void group_type_insert(c_group_type t);

        [OperationContract]
        void group_type_update(c_group_type t);
        [OperationContract]
        List<V_group_type> group_type_Read();

        //[OperationContract]
        //V_group_type group_type_FilterRead(Expression<Func<V_group_type, bool>> filtre);

        [OperationContract]
        void group_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void imports_export_insert(c_imports_export t);

        [OperationContract]
        void imports_export_update(c_imports_export t);
        [OperationContract]
        List<V_imports_export> imports_export_Read();

        //[OperationContract]
        //V_imports_export imports_export_FilterRead(Expression<Func<V_imports_export, bool>> filtre);

        [OperationContract]
        void imports_export_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void inventory_insert(c_inventory t);

        [OperationContract]
        void inventory_update(c_inventory t);
        [OperationContract]
        List<V_inventory> inventory_Read();

        //[OperationContract]
        //V_inventory inventory_FilterRead(Expression<Func<V_inventory, bool>> filtre);

        [OperationContract]
        void inventory_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void main_unit_insert(c_main_unit t);

        [OperationContract]
        void main_unit_update(c_main_unit t);
        [OperationContract]
        List<V_main_unit> main_unit_Read();

        //[OperationContract]
        //V_main_unit main_unit_FilterRead(Expression<Func<V_main_unit, bool>> filtre);

        [OperationContract]
        void main_unit_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void natification_insert(c_natification t);

        [OperationContract]
        void natification_update(c_natification t);
        [OperationContract]
        List<V_natification> natification_Read();

        //[OperationContract]
        //V_natification natification_FilterRead(Expression<Func<V_natification, bool>> filtre);

        [OperationContract]
        void natification_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void order_insert(c_order t);

        [OperationContract]
        void order_update(c_order t);
        [OperationContract]
        List<V_orders> order_Read();

        //[OperationContract]
        //V_orders order_FilterRead(Expression<Func<V_orders, bool>> filtre);

        [OperationContract]
        void order_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void payment_method_insert(c_payment_method t);

        [OperationContract]
        void payment_method_update(c_payment_method t);
        [OperationContract]
        List<V_payment_method> payment_method_Read();

        //[OperationContract]
        //V_payment_method payment_method_FilterRead(Expression<Func<V_payment_method, bool>> filtre);

        [OperationContract]
        void payment_method_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void payment_plan_insert(c_payment_plan t);

        [OperationContract]
        void payment_plan_update(c_payment_plan t);
        [OperationContract]
        List<V_payment_plan> payment_plan_Read();

        //[OperationContract]
        //V_payment_plan payment_plan_FilterRead(Expression<Func<V_payment_plan, bool>> filtre);

        [OperationContract]
        void payment_plan_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void product_insert(c_product t);

        [OperationContract]
        void product_update(c_product t);
        [OperationContract]
        List<V_product> product_Read();

        //[OperationContract]
        //V_product product_FilterRead(Expression<Func<V_product, bool>> filtre);

        [OperationContract]
        void product_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void product_refund_insert(c_product_refund t);

        [OperationContract]
        void product_refund_update(c_product_refund t);
        [OperationContract]
        List<V_product_refund> product_refund_Read();

        //[OperationContract]
        //V_product_refund product_refund_FilterRead(Expression<Func<V_product_refund, bool>> filtre);

        [OperationContract]
        void product_refund_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void product_type_insert(c_product_type t);

        [OperationContract]
        void product_type_update(c_product_type t);

        [OperationContract]
        List<V_product_type> product_type_Read();

        //[OperationContract]
        //V_product_type product_type_FilterRead(Expression<Func<V_product_type, bool>> filtre);

        [OperationContract]
        void product_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void repository_insert(c_repository t);

        [OperationContract]
        void repository_update(c_repository t);
        [OperationContract]
        List<V_repository> repository_Read();

        //[OperationContract]
        //V_repository repository_FilterRead(Expression<Func<V_repository, bool>> filtre);

        [OperationContract]
        void repository_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void sector_insert(c_sector t);

        [OperationContract]
        void sector_update(c_sector t);
        [OperationContract]
        List<V_sector> sector_Read();

        //[OperationContract]
        //V_sector sector_FilterRead(Expression<Func<V_sector, bool>> filtre);

        [OperationContract]
        void sector_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void shipment_slip_insert(c_shipment_slip t);

        [OperationContract]
        void shipment_slip_update(c_shipment_slip t);

        [OperationContract]
        List<V_shipment_slip> shipment_slip_Read();

        //[OperationContract]
        //V_shipment_slip shipment_slip_FilterRead(Expression<Func<V_shipment_slip, bool>> filtre);

        [OperationContract]
        void shipment_slip_Delete(int id);

        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void sold_product_insert(c_sold_product t);

        [OperationContract]
        void sold_product_update(c_sold_product t);
        [OperationContract]
        List<V_sold_product> sold_product_Read();

        //[OperationContract]
        //V_sold_product sold_product_FilterRead(Expression<Func<V_sold_product, bool>> filtre);

        [OperationContract]
        void sold_product_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void supplier_insert(c_supplier t);

        [OperationContract]
        void supplier_update(c_supplier t);
        [OperationContract]
        List<V_suppliers> supplier_Read();

        //[OperationContract]
        //V_suppliers supplier_FilterRead(Expression<Func<V_suppliers, bool>> filtre);

        [OperationContract]
        void supplier_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void suppliers_type_insert(c_suppliers_type t);

        [OperationContract]
        void suppliers_type_update(c_suppliers_type t);
        [OperationContract]
        List<V_suppliers_type> suppliers_type_Read();

        //[OperationContract]
        //V_suppliers_type suppliers_type_FilterRead(Expression<Func<V_suppliers_type, bool>> filtre);

        [OperationContract]
        void suppliers_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void Tax_Administration_insert(c_Tax_Administration t);

        [OperationContract]
        void Tax_Administration_update(c_Tax_Administration t);
        [OperationContract]
        List<V_Tax_Administration> Tax_Administration_Read();

        //[OperationContract]
        //V_Tax_Administration Tax_Administration_FilterRead(Expression<Func<V_Tax_Administration, bool>> filtre);

        [OperationContract]
        void Tax_Administration_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void transport_type_insert(c_transport_type t);

        [OperationContract]
        void transport_type_update(c_transport_type t);
        [OperationContract]
        List<V_transport_type> transport_type_Read();

        //[OperationContract]
        //V_transport_type transport_type_FilterRead(Expression<Func<V_transport_type, bool>> filtre);

        [OperationContract]
        void transport_type_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void User_insert(c_User t);

        [OperationContract]
        void User_update(c_User t);
        [OperationContract]
        List<V_Users> User_Read();

        //[OperationContract]
        //V_Users User_FilterRead(Expression<Func<V_Users, bool>> filtre);

        [OperationContract]
        void User_Delete(int id);
        /////////////////////////////////////////////////////////////////////////
        ///
        [OperationContract]
        void Users_authority_insert(c_Users_authority t);

        [OperationContract]
        void Users_authority_update(c_Users_authority t);

        [OperationContract]
        List<V_Users_authority> Users_authority_Read();

        //[OperationContract]
        //V_Users_authority Users_authority_FilterRead(Expression<Func<V_Users_authority, bool>> filtre);

        [OperationContract]
        void Users_authority_Delete(int id);

        [OperationContract]
        bool login(string username, string password);

    }
}
