// Delete item

function DeleteItem(url) {
    $(document).ready(function () {
        $(".delete-from-db").click(function () {
            let id = $(this).attr("data-id");
            let removeItem = $(this).parent().parent().parent();
            let data = { id: id };

            $.ajax({
                url: url,
                type: "POST",
                data: data,
                success: function () {
                    removeItem.remove();
                }
            })
        })
    })
}

DeleteItem("/Admin/Slider/Delete");
DeleteItem("/Admin/Advantage/Delete");
DeleteItem("/Admin/Banner/Delete");
DeleteItem("/Admin/Brand/Delete");
DeleteItem("/Admin/Product/Delete");
DeleteItem("/Admin/Size/Delete");
DeleteItem("/Admin/Category/Delete");
DeleteItem("/Admin/Color/Delete");
DeleteItem("/Admin/Tag/Delete");
DeleteItem("/Admin/Contact/Delete");
DeleteItem("/Admin/BlogComment/Delete");
DeleteItem("/Admin/ProductComment/Delete");