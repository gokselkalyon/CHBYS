using CHBYS.BUSINESSLAYER.Respository.concreteclass;
using CHBYS.ENTITIES;
using CHBYS.ENTITIES.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CHBYS.WCFSERVICE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void authorization_code_Delete(int id)
        {
            authorization_code_business db = new authorization_code_business();
            db.Delete(id);
        }

        public V_authorization_code authorization_code_FilterRead(Expression<Func<V_authorization_code, bool>> filtre)
        {
            authorization_code_business db = new authorization_code_business();
            return db.FilterRead(filtre);
        }

        public void authorization_code_insert(c_authorization_code t)
        {
            authorization_code_business db = new authorization_code_business();
            db.Create(t);
        }

        public List<V_authorization_code> authorization_code_Read()
        {
            authorization_code_business db = new authorization_code_business();
            return db.Read();
        }

        public void authorization_code_type_Delete(int id)
        {
            authorization_code_type_business db = new authorization_code_type_business();
            db.Delete(id);
        }

        public V_authorization_code_type authorization_code_type_FilterRead(Expression<Func<V_authorization_code_type, bool>> filtre)
        {
            authorization_code_type_business db = new authorization_code_type_business();
            return db.FilterRead(filtre);
        }

        public void authorization_code_type_insert(c_authorization_code_type t)
        {
            authorization_code_type_business db = new authorization_code_type_business();
            db.Create(t);
        }

        public void authorization_code_type_update(c_authorization_code_type t)
        {
            authorization_code_type_business db = new authorization_code_type_business();
        }

        public void authorization_code_update(c_authorization_code t)
        {
            authorization_code_type_business db = new authorization_code_type_business();
        }

        public void bank_Delete(int id)
        {
            bank_business db = new bank_business();
            db.Delete(id);
        }

        public V_bank bank_FilterRead(Expression<Func<V_bank, bool>> filtre)
        {
            bank_business db = new bank_business();
            return db.FilterRead(filtre);
        }

        public void bank_insert(c_bank t)
        {
            bank_business db = new bank_business();
            db.Create(t);
        }

        public List<V_bank> bank_Read()
        {
            bank_business db = new bank_business();
            return db.Read();
        }

        public void bank_update(c_bank t)
        {
            bank_business db = new bank_business();
        }

        public void barcode_Delete(int id)
        {
            barcode_business db = new barcode_business();
            db.Delete(id);
        }

        public V_barcode barcode_FilterRead(Expression<Func<V_barcode, bool>> filtre)
        {
            barcode_business db = new barcode_business();
            return db.FilterRead(filtre);
        }

        public void barcode_insert(c_barcode t)
        {
            barcode_business db = new barcode_business();
            db.Create(t);
        }

        public List<V_barcode> barcode_Read()
        {
            barcode_business db = new barcode_business();
            return db.Read();
        }

        public void barcode_update(c_barcode t)
        {
            barcode_business db = new barcode_business();
        }

        public V_brand brand_FilterRead(Expression<Func<V_brand, bool>> filtre)
        {
            brand_business db = new brand_business();
            return db.FilterRead(filtre);
        }

        public void brand_insert(c_brand t)
        {
            brand_business db = new brand_business();
            db.Create(t);
        }

        public List<V_brand> brand_Read()
        {
            brand_business db = new brand_business();
            return db.Read();
        }

        public void brand_update(c_brand t)
        {
            brand_business db = new brand_business();
        }

        public void cargo_company_Delete(int id)
        {
            cargo_company_business db = new cargo_company_business();
            db.Delete(id);
        }

        public V_cargo_company cargo_company_FilterRead(Expression<Func<V_cargo_company, bool>> filtre)
        {
            cargo_company_business db = new cargo_company_business();
            return db.FilterRead(filtre);
        }

        public void cargo_company_insert(c_cargo_company t)
        {
            cargo_company_business db = new cargo_company_business();
            db.Create(t);
        }

        public void cargo_company_name_Delete(int id)
        {
            cargo_company_name_business db = new cargo_company_name_business();
            db.Delete(id);
        }

        public V_cargo_company_name cargo_company_name_FilterRead(Expression<Func<V_cargo_company_name, bool>> filtre)
        {
            cargo_company_name_business db = new cargo_company_name_business();
            return db.FilterRead(filtre);
        }

        public void cargo_company_name_insert(c_cargo_company_name t)
        {
            cargo_company_name_business db = new cargo_company_name_business();
            db.Create(t);
        }

        public List<V_cargo_company_name> cargo_company_name_Read()
        {
            cargo_company_name_business db = new cargo_company_name_business();
            return db.Read();
        }

        public void cargo_company_name_update(c_cargo_company_name t)
        {
            cargo_company_name_business db = new cargo_company_name_business();
        }

        public List<V_cargo_company> cargo_company_Read()
        {
            cargo_company_business db = new cargo_company_business();
            return db.Read();
        }

        public void cargo_company_update(c_cargo_company t)
        {
            cargo_company_business db = new cargo_company_business();
        }

        public void city_Delete(int id)
        {
            city_business db = new city_business();
            db.Delete(id);
        }

        public V_city city_FilterRead(Expression<Func<V_city, bool>> filtre)
        {
            city_business db = new city_business();
            return db.FilterRead(filtre);
        }

        public void city_insert(c_city t)
        {
            city_business db = new city_business();
            db.Create(t);
        }

        public List<V_city> city_Read()
        {
            city_business db = new city_business();
            return db.Read();
        }

        public void city_update(c_city t)
        {
            city_business db = new city_business();
        }

        public void company_Delete(int id)
        {
            company_business db = new company_business();
            db.Delete(id);
        }

        public V_company company_FilterRead(Expression<Func<V_company, bool>> filtre)
        {
            company_business db = new company_business();
            return db.FilterRead(filtre);
        }

        public void company_insert(c_company t)
        {
            company_business db = new company_business();
            db.Create(t);
        }

        public List<V_company> company_Read()
        {
            company_business db = new company_business();
            return db.Read();
        }

        public void company_type_Delete(int id)
        {
            company_type_business db = new company_type_business();
            db.Delete(id);
        }

        public void company_type_insert(c_company_type t)
        {
            company_type_business db = new company_type_business();
            db.Create(t);
        }

        public void company_type_update(c_company_type t)
        {
            company_type_business db = new company_type_business();
        }

        public void company_update(c_company t)
        {
            company_business db = new company_business();
        }

        public void country_Delete(int id)
        {
            country_business db = new country_business();
            db.Delete(id);
        }

        public V_country country_FilterRead(Expression<Func<V_country, bool>> filtre)
        {
            country_business db = new country_business();
            return db.FilterRead(filtre);
        }

        public void country_insert(c_country t)
        {
            country_business db = new country_business();
            db.Create(t);
        }

        public List<V_country> country_Read()
        {
            country_business db = new country_business();
            return db.Read();
        }

        public void country_update(c_country t)
        {
            country_business db = new country_business();
        }

        public void county_Delete(int id)
        {
            county_business db = new county_business();
            db.Delete(id);
        }

        public V_county county_FilterRead(Expression<Func<V_county, bool>> filtre)
        {
            county_business db = new county_business();
            return db.FilterRead(filtre);
        }

        public void county_insert(c_county t)
        {
            county_business db = new county_business();
            db.Create(t);
        }

        public List<V_county> county_Read()
        {
            county_business db = new county_business();
            return db.Read();
        }

        public void county_update(c_county t)
        {
            county_business db = new county_business();
        }

        public void currency_Delete(int id)
        {
            currency_business db = new currency_business();
            db.Delete(id);
        }

        public V_currency currency_FilterRead(Expression<Func<V_currency, bool>> filtre)
        {
            currency_business db = new currency_business();
            return db.FilterRead(filtre);
        }

        public void currency_insert(c_currency t)
        {
            currency_business db = new currency_business();
            db.Create(t);
        }

        public List<V_currency> currency_Read()
        {
            currency_business db = new currency_business();
            return db.Read();
        }

        public void currency_update(c_currency t)
        {
            currency_business db = new currency_business();
        }

        public void discountcart_Delete(int id)
        {
            discountcart_business db = new discountcart_business();
            db.Delete(id);
        }

        public V_discountcart discountcart_FilterRead(Expression<Func<V_discountcart, bool>> filtre)
        {
            discountcart_business db = new discountcart_business();
            return db.FilterRead(filtre);
        }

        public void discountcart_insert(c_discountcart t)
        {
            discountcart_business db = new discountcart_business();
            db.Create(t);
        }

        public List<V_discountcart> discountcart_Read()
        {
            discountcart_business db = new discountcart_business();
            return db.Read();
        }

        public void discountcart_update(c_discountcart t)
        {
            discountcart_business db = new discountcart_business();
        }

        public void employee_Delete(int id)
        {
            employee_business db = new employee_business();
            db.Delete(id);
        }

        public V_employees employee_FilterRead(Expression<Func<V_employees, bool>> filtre)
        {
            employee_business db = new employee_business();
            return db.FilterRead(filtre);
        }

        public void employee_insert(c_employee t)
        {
            employee_business db = new employee_business();
            db.Create(t);
        }

        public void employee_overtime_Delete(int id)
        {
            employee_overtime_business db = new employee_overtime_business();
            db.Delete(id);
        }

        public V_employee_overtime employee_overtime_FilterRead(Expression<Func<V_employee_overtime, bool>> filtre)
        {
            employee_overtime_business db = new employee_overtime_business();
            return db.FilterRead(filtre);
        }

        public void employee_overtime_insert(c_employee_overtime t)
        {
            employee_overtime_business db = new employee_overtime_business();
            db.Create(t);
        }

        public List<V_employee_overtime> employee_overtime_Read()
        {
            employee_overtime_business db = new employee_overtime_business();
            return db.Read();
        }

        public void employee_overtime_update(c_employee_overtime t)
        {
            employee_overtime_business db = new employee_overtime_business();
        }

        public void employee_permission_Delete(int id)
        {
            employee_permission_business db = new employee_permission_business();
            db.Delete(id);
        }

        public V_employee_permission employee_permission_FilterRead(Expression<Func<V_employee_permission, bool>> filtre)
        {
            employee_permission_business db = new employee_permission_business();
            return db.FilterRead(filtre);
        }

        public void employee_permission_insert(c_employee_permission t)
        {
            employee_permission_business db = new employee_permission_business();
            db.Create(t);
        }

        public List<V_employee_permission> employee_permission_Read()
        {
            employee_permission_business db = new employee_permission_business();
            return db.Read();
        }

        public void employee_permission_update(c_employee_permission t)
        {
            employee_permission_business db = new employee_permission_business();
        }

        public void employee_position_Delete(int id)
        {
            employee_position_business db = new employee_position_business();
            db.Delete(id);
        }

        public V_employee_position employee_position_FilterRead(Expression<Func<V_employee_position, bool>> filtre)
        {
            employee_position_business db = new employee_position_business();
            return db.FilterRead(filtre);
        }

        public void employee_position_insert(c_employee_position t)
        {
            employee_position_business db = new employee_position_business();
            db.Create(t);
        }

        public List<V_employee_position> employee_position_Read()
        {
            employee_position_business db = new employee_position_business();
            return db.Read();
        }

        public void employee_position_update(c_employee_position t)
        {
            employee_position_business db = new employee_position_business();
        }

        public List<V_employees> employee_Read()
        {
            employee_business db = new employee_business();
            return db.Read();
        }

        public void employee_update(c_employee t)
        {
            employee_business db = new employee_business();
        }

        public void E_invoice_type_Delete(int id)
        {
            E_invoice_type_business db = new E_invoice_type_business();
            db.Delete(id);
        }

        public V_E_invoice_type E_invoice_type_FilterRead(Expression<Func<V_E_invoice_type, bool>> filtre)
        {
            E_invoice_type_business db = new E_invoice_type_business();
            return db.FilterRead(filtre);
        }

        public void E_invoice_type_insert(c_E_invoice_type t)
        {
            E_invoice_type_business db = new E_invoice_type_business();
            db.Create(t);
        }

        public List<V_E_invoice_type> E_invoice_type_Read()
        {
            E_invoice_type_business db = new E_invoice_type_business();
            return db.Read();
        }

        public void E_invoice_type_update(c_E_invoice_type t)
        {
            E_invoice_type_business db = new E_invoice_type_business();
        }

        public void e_waybill_Delete(int id)
        {
            e_waybill_business db = new e_waybill_business();
            db.Delete(id);
        }

        public V_e_waybill e_waybill_FilterRead(Expression<Func<V_e_waybill, bool>> filtre)
        {
            e_waybill_business db = new e_waybill_business();
            return db.FilterRead(filtre);
        }

        public void e_waybill_insert(c_e_waybill t)
        {
            e_waybill_business db = new e_waybill_business();
            db.Create(t);
        }

        public List<V_e_waybill> e_waybill_Read()
        {
            e_waybill_business db = new e_waybill_business();
            return db.Read();
        }

        public void e_waybill_update(c_e_waybill t)
        {
            e_waybill_business db = new e_waybill_business();
        }

        public void group_code_Delete(int id)
        {
            group_code_business db = new group_code_business();
            db.Delete(id);
        }

        public V_group_code group_code_FilterRead(Expression<Func<V_group_code, bool>> filtre)
        {
            group_code_business db = new group_code_business();
            return db.FilterRead(filtre);
        }

        public void group_code_insert(c_group_code t)
        {
            group_code_business db = new group_code_business();
            db.Create(t);
        }

        public List<V_group_code> group_code_Read()
        {
            group_code_business db = new group_code_business();
            return db.Read();
        }

        public void group_code_update(c_group_code t)
        {
            group_code_business db = new group_code_business();
        }

        public void group_type_Delete(int id)
        {
            group_type_business db = new group_type_business();
            db.Delete(id);
        }

        public V_group_type group_type_FilterRead(Expression<Func<V_group_type, bool>> filtre)
        {
            group_type_business db = new group_type_business();
            return db.FilterRead(filtre);
        }

        public void group_type_insert(c_group_type t)
        {
            group_type_business db = new group_type_business();
            db.Create(t);
        }

        public List<V_group_type> group_type_Read()
        {
            group_type_business db = new group_type_business();
            return db.Read();
        }

        public void group_type_update(c_group_type t)
        {
            group_type_business db = new group_type_business();
        }

        public void imports_export_Delete(int id)
        {
            imports_export_business db = new imports_export_business();
            db.Delete(id);
        }

        public V_imports_export imports_export_FilterRead(Expression<Func<V_imports_export, bool>> filtre)
        {
            imports_export_business db = new imports_export_business();
            return db.FilterRead(filtre);
        }

        public void imports_export_insert(c_imports_export t)
        {
            imports_export_business db = new imports_export_business();
            db.Create(t);
        }

        public List<V_imports_export> imports_export_Read()
        {
            imports_export_business db = new imports_export_business();
            return db.Read();
        }

        public void imports_export_update(c_imports_export t)
        {
            imports_export_business db = new imports_export_business();
            throw new NotImplementedException();
        }

        public void inventory_Delete(int id)
        {
            inventory_business db = new inventory_business();
            db.Delete(id);
        }

        public V_inventory inventory_FilterRead(Expression<Func<V_inventory, bool>> filtre)
        {
            inventory_business db = new inventory_business();
            return db.FilterRead(filtre);
        }

        public void inventory_insert(c_inventory t)
        {
            inventory_business db = new inventory_business();
            db.Create(t);
        }

        public List<V_inventory> inventory_Read()
        {
            inventory_business db = new inventory_business();
            return db.Read();
        }

        public void inventory_update(c_inventory t)
        {
            inventory_business db = new inventory_business();
            throw new NotImplementedException();
        }

        public void main_unit_Delete(int id)
        {
            main_unit_business db = new main_unit_business();
            db.Delete(id);
        }

        public V_main_unit main_unit_FilterRead(Expression<Func<V_main_unit, bool>> filtre)
        {
            main_unit_business db = new main_unit_business();
            return db.FilterRead(filtre);
        }

        public void main_unit_insert(c_main_unit t)
        {
            main_unit_business db = new main_unit_business();
            db.Create(t);
        }

        public List<V_main_unit> main_unit_Read()
        {
            main_unit_business db = new main_unit_business();
            return db.Read();
        }

        public void main_unit_update(c_main_unit t)
        {
            main_unit_business db = new main_unit_business();
            throw new NotImplementedException();
        }

        public void natification_Delete(int id)
        {
            natification_business db = new natification_business();
            db.Delete(id);
        }

        public V_natification natification_FilterRead(Expression<Func<V_natification, bool>> filtre)
        {
            natification_business db = new natification_business();
            return db.FilterRead(filtre);
        }

        public void natification_insert(c_natification t)
        {
            natification_business db = new natification_business();
            db.Create(t);
        }

        public List<V_natification> natification_Read()
        {
            natification_business db = new natification_business();
            return db.Read();
        }

        public void natification_update(c_natification t)
        {
            natification_business db = new natification_business();
            throw new NotImplementedException();
        }

        public void order_Delete(int id)
        {
            order_business db = new order_business();
            db.Delete(id);
        }

        public V_orders order_FilterRead(Expression<Func<V_orders, bool>> filtre)
        {
            order_business db = new order_business();
            return db.FilterRead(filtre);
        }

        public void order_insert(c_order t)
        {
            order_business db = new order_business();
            db.Create(t);
        }

        public List<V_orders> order_Read()
        {
            order_business db = new order_business();
            return db.Read();
        }

        public void order_update(c_order t)
        {
            order_business db = new order_business();
            throw new NotImplementedException();
        }

        public void payment_method_Delete(int id)
        {
            payment_method_business db = new payment_method_business();
            db.Delete(id);
        }

        public V_payment_method payment_method_FilterRead(Expression<Func<V_payment_method, bool>> filtre)
        {
            payment_method_business db = new payment_method_business();
            return db.FilterRead(filtre);
        }

        public void payment_method_insert(c_payment_method t)
        {
            payment_method_business db = new payment_method_business();
            db.Create(t);
        }

        public List<V_payment_method> payment_method_Read()
        {
            payment_method_business db = new payment_method_business();
            return db.Read();
        }

        public void payment_method_update(c_payment_method t)
        {
            payment_method_business db = new payment_method_business();
            throw new NotImplementedException();
        }

        public void payment_plan_Delete(int id)
        {
            payment_plan_business db = new payment_plan_business();
            db.Delete(id);
        }

        public V_payment_plan payment_plan_FilterRead(Expression<Func<V_payment_plan, bool>> filtre)
        {
            payment_plan_business db = new payment_plan_business();
            return db.FilterRead(filtre);
        }

        public void payment_plan_insert(c_payment_plan t)
        {
            payment_plan_business db = new payment_plan_business();
            db.Create(t);
        }

        public List<V_payment_plan> payment_plan_Read()
        {
            payment_plan_business db = new payment_plan_business();
            return db.Read();
        }

        public void payment_plan_update(c_payment_plan t)
        {
            payment_plan_business db = new payment_plan_business();
            throw new NotImplementedException();
        }

        public void product_Delete(int id)
        {
            product_business db = new product_business();
            db.Delete(id);
        }

        public V_product product_FilterRead(Expression<Func<V_product, bool>> filtre)
        {
            product_business db = new product_business();
            return db.FilterRead(filtre);
        }

        public void product_insert(c_product t)
        {
            product_business db = new product_business();
            db.Create(t);
        }

        public List<V_product> product_Read()
        {
            product_business db = new product_business();
            return db.Read();
        }

        public void product_refund_Delete(int id)
        {
            product_refund_business db = new product_refund_business();
            db.Delete(id);
        }

        public V_product_refund product_refund_FilterRead(Expression<Func<V_product_refund, bool>> filtre)
        {
            product_refund_business db = new product_refund_business();
            return db.FilterRead(filtre);
        }

        public void product_refund_insert(c_product_refund t)
        {
            product_refund_business db = new product_refund_business();
            db.Create(t);
        }

        public List<V_product_refund> product_refund_Read()
        {
            product_refund_business db = new product_refund_business();
            return db.Read();
        }

        public void product_refund_update(c_product_refund t)
        {
            product_refund_business db = new product_refund_business();
            throw new NotImplementedException();
        }

        public void product_type_Delete(int id)
        {
            product_type_business db = new product_type_business();
            db.Delete(id);
        }

        public V_product_type product_type_FilterRead(Expression<Func<V_product_type, bool>> filtre)
        {
            product_type_business db = new product_type_business();
            return db.FilterRead(filtre);
        }

        public void product_type_insert(c_product_type t)
        {
            product_type_business db = new product_type_business();
            db.Create(t);
        }

        public List<V_product_type> product_type_Read()
        {
            product_type_business db = new product_type_business();
            return db.Read();
        }

        public void product_type_update(c_product_type t)
        {
            product_type_business db = new product_type_business();
            throw new NotImplementedException();
        }

        public void product_update(c_product t)
        {
            product_business db = new product_business();
            throw new NotImplementedException();
        }

        public void repository_Delete(int id)
        {
            repository_business db = new repository_business();
            db.Delete(id);
        }

        public V_repository repository_FilterRead(Expression<Func<V_repository, bool>> filtre)
        {
            repository_business db = new repository_business();
            return db.FilterRead(filtre);
        }

        public void repository_insert(c_repository t)
        {
            repository_business db = new repository_business();
            db.Create(t);
        }

        public List<V_repository> repository_Read()
        {
            repository_business db = new repository_business();
            return db.Read();
        }

        public void repository_update(c_repository t)
        {
            repository_business db = new repository_business();
            throw new NotImplementedException();
        }

        public void sector_Delete(int id)
        {
            sector_business db = new sector_business();
            db.Delete(id);
        }

        public V_sector sector_FilterRead(Expression<Func<V_sector, bool>> filtre)
        {
            sector_business db = new sector_business();
            return db.FilterRead(filtre);
        }

        public void sector_insert(c_sector t)
        {
            sector_business db = new sector_business();
            db.Create(t);
        }

        public List<V_sector> sector_Read()
        {
            sector_business db = new sector_business();
            return db.Read();
        }

        public void sector_update(c_sector t)
        {
            sector_business db = new sector_business();
        }

        public void shipment_slip_Delete(int id)
        {
            shipment_slip_business db = new shipment_slip_business();
            db.Delete(id);
        }

        public V_shipment_slip shipment_slip_FilterRead(Expression<Func<V_shipment_slip, bool>> filtre)
        {
            shipment_slip_business db = new shipment_slip_business();
            return db.FilterRead(filtre);
        }

        public void shipment_slip_insert(c_shipment_slip t)
        {
            shipment_slip_business db = new shipment_slip_business();
            db.Create(t);
        }

        public List<V_shipment_slip> shipment_slip_Read()
        {
            shipment_slip_business db = new shipment_slip_business();
            return db.Read();
        }

        public void shipment_slip_update(c_shipment_slip t)
        {
            shipment_slip_business db = new shipment_slip_business();
        }

        public void sold_product_Delete(int id)
        {
            sold_product_business db = new sold_product_business();
            db.Delete(id);
        }

        public V_sold_product sold_product_FilterRead(Expression<Func<V_sold_product, bool>> filtre)
        {
            sold_product_business db = new sold_product_business();
            return db.FilterRead(filtre);
        }

        public void sold_product_insert(c_sold_product t)
        {
            sold_product_business db = new sold_product_business();
            db.Create(t);
        }

        public List<V_sold_product> sold_product_Read()
        {
            sold_product_business db = new sold_product_business();
            return db.Read();
        }

        public void sold_product_update(c_sold_product t)
        {
            sold_product_business db = new sold_product_business();
            db.Update(t);
        }

        public void suppliers_type_Delete(int id)
        {
            suppliers_type_business db = new suppliers_type_business();
            db.Delete(id);
        }

        public V_suppliers_type suppliers_type_FilterRead(Expression<Func<V_suppliers_type, bool>> filtre)
        {
            suppliers_type_business db = new suppliers_type_business();
            return db.FilterRead(filtre);
        }

        public void suppliers_type_insert(c_suppliers_type t)
        {
            suppliers_type_business db = new suppliers_type_business();
            db.Create(t);
        }

        public List<V_suppliers_type> suppliers_type_Read()
        {
            suppliers_type_business db = new suppliers_type_business();
            return db.Read();
        }

        public void suppliers_type_update(c_suppliers_type t)
        {
            suppliers_type_business db = new suppliers_type_business();
            throw new NotImplementedException();
        }

        public void supplier_Delete(int id)
        {
            supplier_business db = new supplier_business();
            db.Delete(id);
        }

        public V_suppliers supplier_FilterRead(Expression<Func<V_suppliers, bool>> filtre)
        {
            supplier_business db = new supplier_business();
            return db.FilterRead(filtre);
        }

        public void supplier_insert(c_supplier t)
        {
            supplier_business db = new supplier_business();
            db.Create(t);
        }

        public List<V_suppliers> supplier_Read()
        {
            supplier_business db = new supplier_business();
            return db.Read();
        }

        public void supplier_update(c_supplier t)
        {
            supplier_business db = new supplier_business();
            db.Update(t);
        }

        public void Tax_Administration_Delete(int id)
        {
            Tax_Administration_business db = new Tax_Administration_business();
            db.Delete(id);
        }

        public V_Tax_Administration Tax_Administration_FilterRead(Expression<Func<V_Tax_Administration, bool>> filtre)
        {
            Tax_Administration_business db = new Tax_Administration_business();
            return db.FilterRead(filtre);
        }

        public void Tax_Administration_insert(c_Tax_Administration t)
        {
            Tax_Administration_business db = new Tax_Administration_business();
            db.Create(t);
        }

        public List<V_Tax_Administration> Tax_Administration_Read()
        {
            Tax_Administration_business db = new Tax_Administration_business();
            return db.Read();
        }

        public void Tax_Administration_update(c_Tax_Administration t)
        {
            Tax_Administration_business db = new Tax_Administration_business();
        }

        public void transport_type_Delete(int id)
        {
            transport_type_business db = new transport_type_business();
            db.Delete(id);
        }

        public V_transport_type transport_type_FilterRead(Expression<Func<V_transport_type, bool>> filtre)
        {
            transport_type_business db = new transport_type_business();
            return db.FilterRead(filtre);
        }

        public void transport_type_insert(c_transport_type t)
        {
            transport_type_business db = new transport_type_business();
            db.Create(t);
        }

        public List<V_transport_type> transport_type_Read()
        {
            transport_type_business db = new transport_type_business();
            return db.Read();
        }

        public void transport_type_update(c_transport_type t)
        {
            transport_type_business db = new transport_type_business();
        }

        public void Users_authority_Delete(int id)
        {
            Users_authority_business db = new Users_authority_business();
            db.Delete(id);
        }

        public V_Users_authority Users_authority_FilterRead(Expression<Func<V_Users_authority, bool>> filtre)
        {
            Users_authority_business db = new Users_authority_business();
            return db.FilterRead(filtre);
        }

        public void Users_authority_insert(c_Users_authority t)
        {
            Users_authority_business db = new Users_authority_business();
            db.Create(t);
        }

        public List<V_Users_authority> Users_authority_Read()
        {
            Users_authority_business db = new Users_authority_business();
            return db.Read();
        }

        public void Users_authority_update(c_Users_authority t)
        {
            Users_authority_business db = new Users_authority_business();
        }

        public void User_Delete(int id)
        {
            User_business db = new User_business();
            db.Delete(id);
        }

        public V_Users User_FilterRead(Expression<Func<V_Users, bool>> filtre)
        {
            User_business db = new User_business();
            return db.FilterRead(filtre);
        }

        public void User_insert(c_User t)
        {
            User_business db = new User_business();
            db.Create(t);
        }

        public List<V_Users> User_Read()
        {
            User_business db = new User_business();
            return db.Read();
        }

        public void User_update(c_User t)
        {
            User_business db = new User_business();
        }

        public void brand_Delete(int id)
        {
            brand_business db = new brand_business();
            db.Delete(id);
        }

        public List<V_authorization_code_type> authorization_code_type_Read()
        {
            authorization_code_type_business db = new authorization_code_type_business();
            return db.Read();
        }

        public bool login(string username, string password)
        {
            CARIHESAPBILGIYONETIMSISTEMIEntities db = new CARIHESAPBILGIYONETIMSISTEMIEntities();

            if (db.V_Users.Where(x => x.KULLANICI_ADI == username && x.SIFRE == password).FirstOrDefault() != null)
            return true;
            else
            return false;
        }
    }
}
