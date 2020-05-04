using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public class UnitOfWork : IDisposable
    {
        dbAfrzEntities db = new dbAfrzEntities();
        private IPartTypes _partTypes;
        private ICategories _categories;
        private IStore _stores;
        private IPartName _partName;
        private IPartBranch _partBranch;
        private IPartSubBranch _partSubBranch;
        private IMeasurementUnits _measurementUnits;
        private IProperties _properties;
        private IShift _shift;
        private IDepartment _department;
        private ISubDepartment _subDepartment;
        private IMaintenanceItem _maintenanceItem;
        private IMaintenanceParts _maintenanceParts;
        private IEmployees _employees;
        private IMaintenance _maintenance;
        private IZone _zone;
        private ISubZone _subZone;
        private IEquipName _equipName;
        private IEquipSamples _equipSamples;
        private ICompanies _companies;
        private ILocations _locations;
        private ITechnicalDocuments _technicalDocuments;
        private ITechnicalDocumentItems _technicalDocumentItems;
        private IPartSamples _partSamples;
        private ITechnicalDocumentTypes _technicalDocumentTypes;
        private IProjects _projects;
        private ISubProjects _subProjects;
        private IVendors _vendors;
        private IInvoices _invoices;


        public IInvoices Invoices
        {
            get
            {
                if (_invoices == null)
                {
                    _invoices = new InvoicesService(db);
                }

                return _invoices;
            }

        }
        public IVendors Vendors
        {
            get
            {
                if (_vendors == null)
                {
                    _vendors = new VendorsService(db);
                }

                return _vendors;
            }
        }


        public IPartTypes PartTypes
        {
            get
            {
                if (_partTypes == null)
                {
                    _partTypes = new PartTypesService(db);
                }
                return _partTypes;
            }
        }

        public ICategories Categories
        {
            get
            {
                if (_categories == null)
                {
                    _categories = new Categories(db);
                }

                return _categories;
            }
        }

        public IStore Stores
        {
            get
            {
                if (_stores == null)
                {
                    _stores = new Store(db);
                }

                return _stores;
            }
        }

        public IPartName PartName
        {
            get
            {
                if (_partName == null)
                {
                    _partName = new PartNameService(db);
                }

                return _partName;
            }
        }

        public IPartBranch PartBranch
        {
            get
            {
                if (_partBranch == null)
                {
                    _partBranch = new PartBranchService(db);
                }

                return _partBranch;
            }
        }

        public IPartSubBranch PartSubBranch
        {
            get
            {
                if (_partSubBranch == null)
                {
                    _partSubBranch = new PartSubBranchService(db);
                }

                return _partSubBranch;
            }
        }

        public IMeasurementUnits MeasurementUnits
        {
            get
            {
                if (_measurementUnits == null)
                {
                    _measurementUnits = new MeasurementUnits(db);
                }

                return _measurementUnits;
            }
        }

        public IProperties properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new Properties(db);
                }

                return _properties;
            }
        }

        public IShift shift
        {
            get
            {
                if (_shift == null)
                {
                    _shift = new Shift(db);
                }

                return _shift;
            }
        }

        public IDepartment department
        {
            get
            {
                if (_department == null)
                {
                    _department = new DepartmentService(db);
                }

                return _department;
            }
        }

        public ISubDepartment subDepartment
        {
            get
            {
                if (_subDepartment == null)
                {
                    _subDepartment = new SubDepartmentService(db);
                }

                return _subDepartment;
            }
        }

        public IMaintenanceItem MaintenanceItem
        {
            get
            {
                if (_maintenanceItem == null)
                {
                    _maintenanceItem = new MaintenanceItemsService(db);
                }

                return _maintenanceItem;
            }
        }

        public IMaintenanceParts MaintenanceParts
        {
            get
            {
                if (_maintenanceParts == null)
                {
                    _maintenanceParts = new MaintenancePartsService(db);
                }

                return _maintenanceParts;
            }
        }

        public IEmployees Employees
        {
            get
            {
                if (_employees == null)
                {
                    _employees = new EmployeesService(db);
                }

                return _employees;
            }

        }

        public IMaintenance Maintenance
        {
            get
            {
                if (_maintenance == null)
                {
                    _maintenance = new MaintenanceService(db);
                }

                return _maintenance;
            }
        }

        public IZone Zone
        {
            get
            {
                if (_zone == null)
                {
                    _zone = new ZoneService(db);
                }

                return _zone;
            }
        }

        public ISubZone SubZone
        {
            get
            {
                if (_subZone == null)
                {
                    _subZone = new SubZoneService(db);
                }

                return _subZone;
            }
        }

        public IEquipName EquipName
        {
            get
            {
                if (_equipName == null)
                {
                    _equipName = new EquipNameService(db);
                }

                return _equipName;
            }
        }

        public IEquipSamples EquipSamples
        {
            get
            {
                if (_equipSamples == null)
                {
                    _equipSamples = new EquipSamplesService(db);
                }

                return _equipSamples;
            }
        }

        public ICompanies Companies
        {
            get
            {
                if (_companies == null)
                {
                    _companies = new CompaniesService(db);
                }

                return _companies;
            }
        }

        public ILocations Locations
        {
            get
            {
                if (_locations == null)
                {
                    _locations = new LocationsService(db);
                }

                return _locations;
            }
        }

        public ITechnicalDocuments TechnicalDocuments
        {
            get
            {
                if (_technicalDocuments == null)
                {
                    _technicalDocuments = new TechnicalDocumentsService(db);
                }

                return _technicalDocuments;
            }
        }

        public ITechnicalDocumentItems TechnicalDocumentItems
        {
            get
            {
                if (_technicalDocumentItems == null)
                {
                    _technicalDocumentItems = new TechnicalDocumentItemsService(db);
                }

                return _technicalDocumentItems;
            }
        }

        public IPartSamples PartSamples
        {
            get
            {
                if (_partSamples == null)
                {
                    _partSamples = new PartSamplesService(db);
                }

                return _partSamples;
            }
        }

        public ITechnicalDocumentTypes TechnicalDocumentTypes
        {
            get
            {
                if (_technicalDocumentTypes == null)
                {
                    _technicalDocumentTypes = new TechnicalDocumentTypesService(db);
                }

                return _technicalDocumentTypes;
            }
        }

        public IProjects Projects
        {
            get
            {
                if (_projects == null)
                {
                    _projects = new ProjectsService(db);
                }

                return _projects;
            }
        }

        public ISubProjects SubProjects
        {
            get
            {
                if (_subProjects == null)
                {
                    _subProjects = new SubProjectsService(db);
                }

                return _subProjects;
            }
        }



        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
