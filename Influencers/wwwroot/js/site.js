    function GetVotes(ArticleId, Votes) {
            $.ajax({
                type: "POST",
                url: "/Article/GetVotes",
                data: { ArticleId: ArticleId, Votes: Votes },
                success: makeStarsFinal(ArticleId, Votes, '#f8ce0b')
            })
    }
var coloredStar = '#f8ce0b';
var uncoloredStar = '#212529';
var numberOfStars = 5;
var makeStarsFinal = function (articleId, starId, color) {
    for (let i = 1; i <= starId; i++) {
        $(`#star-${articleId} span:nth-child(${i})`).css("color", color);
    }
}

function AddHoverForStars(articleId) {
    
    for (let i = 1; i <= numberOfStars; i++) {
        $(`#star-${articleId} span:nth-child(${i})`).on("mouseover", () => { makeStarsFinal(articleId, i, coloredStar) })
    }
}
function RemoveHoverForStars(articleId) {
    for (let i = 1; i <= numberOfStars; i++) {
        $(`#star-${articleId} span:nth-child(${i})`).on("mouseout", () => { makeStarsFinal(articleId, i, uncoloredStar) })
    }
}
    //function VoteSuccesful() {
    //    alert("Your vote has been recorded!");
    //}

$(document).ready(function () {
    $('#summernote').summernote();
    placeholder: 'Enter content';
});