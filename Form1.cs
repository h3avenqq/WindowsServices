using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Services
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            InitDataGrid();
            GetServices();
        }

        private void InitDataGrid()
        {
            DgvServices.Columns.Add("Name", "Name");
            DgvServices.Columns.Add("Id", "Id");
            DgvServices.Columns.Add("Description", "Description");
            DgvServices.Columns.Add("State", "State");
            DgvServices.Columns.Add("CanStop", "CanStop");
            DgvServices.Columns.Add("CanPauseAndContinue", "CanPauseAndContinue");
        }

        private void GetServices()
        {
            DgvServices.Rows.Clear();

            ServiceController[] scServices;
            scServices = ServiceController.GetServices();


            Console.WriteLine("Services running on the local computer:");
            foreach (ServiceController scTemp in scServices)
            {

                ManagementObject wmiService;
                wmiService = new ManagementObject("Win32_Service.Name='" + scTemp.ServiceName + "'");
                wmiService.Get();

                DgvServices.Rows.Add(scTemp.ServiceName,wmiService["ProcessId"], wmiService["Description"], scTemp.Status, scTemp.CanStop?"Yes":"No", 
                    scTemp.CanPauseAndContinue ? "Yes" : "No");
                //https://docs.microsoft.com/ru-ru/windows/win32/cimwin32prov/win32-process - здесь можно узнать название ключа

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetServices();
        }

        private void StartStopService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);

            if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||

                (service.Status.Equals(ServiceControllerStatus.StopPending)))

                service.Start();

            else service.Stop();
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (DgvServices.SelectedRows.Count != 0)
            {
                string name = DgvServices.SelectedRows[0].Cells[0].Value.ToString();
                StartStopService(name);
            }
        }

        private void PauseContinueService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);

            if (service.CanPauseAndContinue &&
                (service.Status.Equals(ServiceControllerStatus.Paused) ||
                (service.Status.Equals(ServiceControllerStatus.PausePending))))

                service.Continue();

            else if (service.CanPauseAndContinue &&
                (service.Status.Equals(ServiceControllerStatus.Running)))

                service.Pause();

            else
                MessageBox.Show("Can't pause/continue");
        }


    }
}
