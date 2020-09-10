function blazorOpenModal(dialog) {
    if (!dialog.open) {
        dialog.showModal();
    }
}

function blazorInitializeModal(dialog, reference) {
    dialog.addEventListener("close", async e => {
        // 👇 Call the C# method from JavaScript
        await reference.invokeMethodAsync("OnClose", dialog.returnValue);
    });
}

function blazorCloseModal(dialog) {
    if (dialog.open) {
        dialog.close();
    }
}