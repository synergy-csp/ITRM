export default class RequestReasons extends Form.Designer {


	async RequestReasons_Grid_OnActionButtonClick(args: Controls.EventArgs.IActionButtonClickEventArgs) {
        if (args.name == "Delete") {
            await this.showConfirm("Talep Nedeni", "Silme işlemini gerçekleştirmek istediğinizden emin misiniz?").then(() => {
                this.fetch.post("DataSource/DeleteRequestReason", { "documentId": args.row.find(x => x.name == "DOCUMENTID").value }).then(() => {
                    this.showToaster("Talep Nedeni", "Silme işlemi başarıyla gerçekleştirildi.", "Success");
                    this.RequestReasons_Grid.reload(true);
                }).catch((err) => {
                    this.showToaster("Talep Nedeni", `Silme işleminde hata oluştu: ${err}`, "Error");
                });
            }).catch((err) => {
                this.showToaster("Talep Nedeni", "Silme işlemi iptal edildi.", "Info");
            });
        }
	}

	async RequestReasons_OnMessageReceived(args: Controls.EventArgs.IMessageReceivedEventArgs) {
        this.RequestReasons_Grid.reload(true);
	}
}