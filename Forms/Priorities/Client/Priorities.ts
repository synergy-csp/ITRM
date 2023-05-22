export default class Priorities extends Form.Designer {


	async Priorities_Grid_OnActionButtonClick(args: Controls.EventArgs.IActionButtonClickEventArgs) {
        if (args.name == "Delete") {
            await this.showConfirm("Öncelik", "Silme işlemini gerçekleştirmek istediğinizden emin misiniz?").then(() => {
                this.fetch.post("DataSource/DeletePriority", { "documentId": args.row.find(x => x.name == "DOCUMENTID").value }).then(() => {
                    this.showToaster("Öncelik", "Silme işlemi başarıyla gerçekleştirildi.", "Success");
                    this.Priorities_Grid.reload(true);
                }).catch((err) => {
                    this.showToaster("Öncelik", `Silme işleminde hata oluştu: ${err}`, "Error");
                });
            }).catch((err) => {
                this.showToaster("Öncelik", "Silme işlemi iptal edildi.", "Info");
            });
        }
	}

	async Priorities_OnMessageReceived(args: Controls.EventArgs.IMessageReceivedEventArgs) {
        this.Priorities_Grid.reload(true);
	}
}