using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagment.Models
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class PurchaseRequestRepository
    {
        private string connectionString;

        public PurchaseRequestRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertPurchaseRequest(string code, int purchaseRequestTypeID, int purchaseRequestMethodID, DateTime requestDate, bool isUrgent, string notes, int requestedByID, bool isApproved, int approvedByID, DateTime approvedDate, int requestedQuantity, int orderedQuantity, int receivedQuantity, bool isConfirmed, int confirmedByID, DateTime confirmedDate, bool hasWorkflow, int workflowID, bool isRejected, int rejectedReasonID, int rejectedByID, DateTime rejectedDate, string rejectNotes, int warehouseID, int currentWorkflowID, int currentWorkflowStepID, bool isClosed, int closedByID, DateTime closeDate, int closeReasonID, string closeNote, DateTime expectedDate, int projectID, int purchaseRequestUpdateReasonID, int createdByID, DateTime createdDate, int updatedByID, DateTime updatedDate)
        {
            string query = @"INSERT INTO PurchaseRequestHead (Code, PurchaseRequestTypeID, PurchaseRequestMethodID, RequestDate, IsUrgent, Notes, RequestedByID, IsApproved, ApprovedByID, ApprovedDate, RequestedQuantity, OrderedQuantity, RecievedQuantity, IsConfirmed, ConfirmedByID, ConfirmedDate, HasWorkFlow, WorkFlowID, IsRejected, RejectedReasonID, RejectedByID, RejectedDate, RejectNotes, WareHouseID, CurrentWorkFlowID, CurrentWorkFlowStepID, IsClosed, ClosedByID, CloseDate, CloseReasonID, CloseNote, ExpectedDate, ProjectID, PurchaseRequestUpdateReasonID, CreatedByID, CreatedDate, UpdatedByID, UpdatedDate)
                        VALUES (@Code, @PurchaseRequestTypeID, @PurchaseRequestMethodID, @RequestDate, @IsUrgent, @Notes, @RequestedByID, @IsApproved, @ApprovedByID, @ApprovedDate, @RequestedQuantity, @OrderedQuantity, @ReceivedQuantity, @IsConfirmed, @ConfirmedByID, @ConfirmedDate, @HasWorkFlow, @WorkFlowID, @IsRejected, @RejectedReasonID, @RejectedByID, @RejectedDate, @RejectNotes, @WareHouseID, @CurrentWorkFlowID, @CurrentWorkFlowStepID, @IsClosed, @ClosedByID, @CloseDate, @CloseReasonID, @CloseNote, @ExpectedDate, @ProjectID, @PurchaseRequestUpdateReasonID, @CreatedByID, @CreatedDate, @UpdatedByID, @UpdatedDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Code", code);
                command.Parameters.AddWithValue("@PurchaseRequestTypeID", purchaseRequestTypeID);
                command.Parameters.AddWithValue("@PurchaseRequestMethodID", purchaseRequestMethodID);
                command.Parameters.AddWithValue("@RequestDate", requestDate);
                command.Parameters.AddWithValue("@IsUrgent", isUrgent);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@RequestedByID", requestedByID);
                command.Parameters.AddWithValue("@IsApproved", isApproved);
                command.Parameters.AddWithValue("@ApprovedByID", approvedByID);
                command.Parameters.AddWithValue("@ApprovedDate", approvedDate);
                command.Parameters.AddWithValue("@RequestedQuantity", requestedQuantity);
                command.Parameters.AddWithValue("@OrderedQuantity", orderedQuantity);
                command.Parameters.AddWithValue("@ReceivedQuantity", receivedQuantity);
                command.Parameters.AddWithValue("@IsConfirmed", isConfirmed);
                command.Parameters.AddWithValue("@ConfirmedByID", confirmedByID);
                command.Parameters.AddWithValue("@ConfirmedDate", confirmedDate);
                command.Parameters.AddWithValue("@HasWorkFlow", hasWorkflow);
                command.Parameters.AddWithValue("@WorkFlowID", workflowID);
                command.Parameters.AddWithValue("@IsRejected", isRejected);
                command.Parameters.AddWithValue("@RejectedReasonID", rejectedReasonID);
                command.Parameters.AddWithValue("@RejectedByID", rejectedByID);
                command.Parameters.AddWithValue("@RejectedDate", rejectedDate);
                command.Parameters.AddWithValue("@RejectNotes", rejectNotes);
                command.Parameters.AddWithValue("@WareHouseID", warehouseID);
                command.Parameters.AddWithValue("@CurrentWorkFlowID", currentWorkflowID);
                command.Parameters.AddWithValue("@CurrentWorkFlowStepID", currentWorkflowStepID);
                command.Parameters.AddWithValue("@IsClosed", isClosed);
                command.Parameters.AddWithValue("@ClosedByID", closedByID);
                command.Parameters.AddWithValue("@CloseDate", closeDate);
                command.Parameters.AddWithValue("@CloseReasonID", closeReasonID);
                command.Parameters.AddWithValue("@CloseNote", closeNote);
                command.Parameters.AddWithValue("@ExpectedDate", expectedDate);
                command.Parameters.AddWithValue("@ProjectID", projectID);
                command.Parameters.AddWithValue("@PurchaseRequestUpdateReasonID", purchaseRequestUpdateReasonID);
                command.Parameters.AddWithValue("@CreatedByID", createdByID);
                command.Parameters.AddWithValue("@CreatedDate", createdDate);
                command.Parameters.AddWithValue("@UpdatedByID", updatedByID);
                command.Parameters.AddWithValue("@UpdatedDate", updatedDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePurchaseRequest(int id, string code, int purchaseRequestTypeID, int purchaseRequestMethodID, DateTime requestDate, bool isUrgent, string notes, int requestedByID, bool isApproved, int approvedByID, DateTime approvedDate, int requestedQuantity, int orderedQuantity, int receivedQuantity, bool isConfirmed, int confirmedByID, DateTime confirmedDate, bool hasWorkflow, int workflowID, bool isRejected, int rejectedReasonID, int rejectedByID, DateTime rejectedDate, string rejectNotes, int warehouseID, int currentWorkflowID, int currentWorkflowStepID, bool isClosed, int closedByID, DateTime closeDate, int closeReasonID, string closeNote, DateTime expectedDate, int projectID, int purchaseRequestUpdateReasonID, int updatedByID, DateTime updatedDate)
        {
            string query = @"UPDATE PurchaseRequestHead
                        SET Code = @Code,
                            PurchaseRequestTypeID = @PurchaseRequestTypeID,
                            PurchaseRequestMethodID = @PurchaseRequestMethodID,
                            RequestDate = @RequestDate,
                            IsUrgent = @IsUrgent,
                            Notes = @Notes,
                            RequestedByID = @RequestedByID,
                            IsApproved = @IsApproved,
                            ApprovedByID = @ApprovedByID,
                            ApprovedDate = @ApprovedDate,
                            RequestedQuantity = @RequestedQuantity,
                            OrderedQuantity = @OrderedQuantity,
                            RecievedQuantity = @RecievedQuantity,
                            IsConfirmed = @IsConfirmed,
                            ConfirmedByID = @ConfirmedByID,
                            ConfirmedDate = @ConfirmedDate,
                            HasWorkFlow = @HasWorkFlow,
                            WorkFlowID = @WorkFlowID,
                            IsRejected = @IsRejected,
                            RejectedReasonID = @RejectedReasonID,
                            RejectedByID = @RejectedByID,
                            RejectedDate = @RejectedDate,
                            RejectNotes = @RejectNotes,
                            WareHouseID = @WareHouseID,
                            CurrentWorkFlowID = @CurrentWorkFlowID,
                            CurrentWorkFlowStepID = @CurrentWorkFlowStepID,
                            IsClosed = @IsClosed,
                            ClosedByID = @ClosedByID,
                            CloseDate = @CloseDate,
                            CloseReasonID = @CloseReasonID,
                            CloseNote = @CloseNote,
                            ExpectedDate = @ExpectedDate,
                            ProjectID = @ProjectID,
                            PurchaseRequestUpdateReasonID = @PurchaseRequestUpdateReasonID,
                            UpdatedByID = @UpdatedByID,
                            UpdatedDate = @UpdatedDate
                        WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Code", code);
                command.Parameters.AddWithValue("@PurchaseRequestTypeID", purchaseRequestTypeID);
                command.Parameters.AddWithValue("@PurchaseRequestMethodID", purchaseRequestMethodID);
                command.Parameters.AddWithValue("@RequestDate", requestDate);
                command.Parameters.AddWithValue("@IsUrgent", isUrgent);
                command.Parameters.AddWithValue("@Notes", notes);
                command.Parameters.AddWithValue("@RequestedByID", requestedByID);
                command.Parameters.AddWithValue("@IsApproved", isApproved);
                command.Parameters.AddWithValue("@ApprovedByID", approvedByID);
                command.Parameters.AddWithValue("@ApprovedDate", approvedDate);
                command.Parameters.AddWithValue("@RequestedQuantity", requestedQuantity);
                command.Parameters.AddWithValue("@OrderedQuantity", orderedQuantity);
                command.Parameters.AddWithValue("@ReceivedQuantity", receivedQuantity);
                command.Parameters.AddWithValue("@IsConfirmed", isConfirmed);
                command.Parameters.AddWithValue("@ConfirmedByID", confirmedByID);
                command.Parameters.AddWithValue("@ConfirmedDate", confirmedDate);
                command.Parameters.AddWithValue("@HasWorkFlow", hasWorkflow);
                command.Parameters.AddWithValue("@WorkFlowID", workflowID);
                command.Parameters.AddWithValue("@IsRejected", isRejected);
                command.Parameters.AddWithValue("@RejectedReasonID", rejectedReasonID);
                command.Parameters.AddWithValue("@RejectedByID", rejectedByID);
                command.Parameters.AddWithValue("@RejectedDate", rejectedDate);
                command.Parameters.AddWithValue("@RejectNotes", rejectNotes);
                command.Parameters.AddWithValue("@WareHouseID", warehouseID);
                command.Parameters.AddWithValue("@CurrentWorkFlowID", currentWorkflowID);
                command.Parameters.AddWithValue("@CurrentWorkFlowStepID", currentWorkflowStepID);
                command.Parameters.AddWithValue("@IsClosed", isClosed);
                command.Parameters.AddWithValue("@ClosedByID", closedByID);
                command.Parameters.AddWithValue("@CloseDate", closeDate);
                command.Parameters.AddWithValue("@CloseReasonID", closeReasonID);
                command.Parameters.AddWithValue("@CloseNote", closeNote);
                command.Parameters.AddWithValue("@ExpectedDate", expectedDate);
                command.Parameters.AddWithValue("@ProjectID", projectID);
                command.Parameters.AddWithValue("@PurchaseRequestUpdateReasonID", purchaseRequestUpdateReasonID);
                command.Parameters.AddWithValue("@UpdatedByID", updatedByID);
                command.Parameters.AddWithValue("@UpdatedDate", updatedDate);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePurchaseRequest(int id)
        {
            string query = "DELETE FROM PurchaseRequestHead WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllPurchaseRequests()
        {
            string query = "SELECT * FROM PurchaseRequestHead";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataRow GetPurchaseRequestById(int id)
        {
            string query = "SELECT * FROM PurchaseRequestHead WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DataTable schemaTable = reader.GetSchemaTable();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable.Rows[0];
                    }
                    return null;
                }
            }
        }
    }

}
