﻿(function () {

    var question = {
        position : [
        "1","2","3","4","5","6","7","8","9"
    ]    
}
    var count = 0;
    $('#add').on('click', function () {
        var current = count++;
        console.log(current);
        if (current < 5) {
            $('#questionId').append(`
        <div class ="col-md-6">
            <label for="questions" class ="control-label">Question</label>
            <textarea cols="2" name="question[${count}]" id="questionid" class ="form-control" required ></textarea>
        </div>
        <div class ="col-md-6">
            <label for="description" class ="control-label">Description</label>
            <textarea cols="2" name="description[${count}]" id="questionid" class ="form-control" required></textarea>
        </div>
                `);
        }
        else {
            $('#overload').removeClass('hidden');
        }
        })

    function AppendItems() {

    }
    windows.onload = AppendItems();

})();