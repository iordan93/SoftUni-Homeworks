<?php
session_start();
require "constants.php";
?>

<?php
// This function shows error messages if needed and returns whether any errors have been found
function validateFields()
{
    $error = false;
    $namesPattern = '/^[A-za-z ]{2,20}$/';

    // Source: http://stackoverflow.com/questions/742451/what-is-the-simplest-regular-expression-to-validate-emails-to-not-accept-them-bl
    $emailPattern = '/^[^@]+@[^@]+\.[^@]+$/';
    $companyPattern = '/^[A-Za-z0-9 ]{2,20}$/';

    // Source: http://stackoverflow.com/questions/15491894/regex-to-validate-date-format-dd-mm-yyyy
    // This accepts dates in one of the following formats: dd/mm/yyyy, dd-mm-yyyy, dd.mm.yyyy
    // The coolest thing - it validates the years, months and dates, and takes leap years into account
    // (for example, 1900 is not a leap year, but 1600 is)
    $datePattern = '/^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$/';
    $phonePattern = '/^(\+{0,}[\d- ]+)$/';

    if (!preg_match($namesPattern, $_POST["firstName"])) {
        echo "<div class=\"error\">Invalid first name.</div>";
        $error = true;
    }

    if (!preg_match($namesPattern, $_POST["lastName"])) {
        echo "<div class=\"error\">Invalid last name.</div>";
        $error = true;
    }

    if(!preg_match($emailPattern, $_POST["email"])){
        echo "<div class=\"error\">Invalid email: {$_POST["email"]}.</div>";
        $error = true;
    }

    if (!preg_match($datePattern, $_POST["birthDate"])) {
        echo "<div class=\"error\">Invalid birth date: {$_POST["birthDate"]}.</div>";
        $error = true;
    }

    if(!preg_match($phonePattern, $_POST["phoneNumber"])){
        echo "<div class=\"error\">Invalid phone: {$_POST["phoneNumber"]}.</div>";
        $error = true;
    }

    if(!preg_match($companyPattern, $_POST["companyName"])){
        echo "<div class=\"error\">Invalid company name.</div>";
        $error = true;
    }

    if (!preg_match($datePattern, $_POST["from"])) {
        echo "<div class=\"error\">Invalid \"from\" date.</div>";
        $error = true;
    }

    if (!preg_match($datePattern, $_POST["to"])) {
        echo "<div class=\"error\">Invalid \"to\" date.</div>";
        $error = true;
    }

    foreach ($_POST["languages"] as $language) {
        if (!preg_match($namesPattern, $language)) {
            echo "<div class=\"error\">Invalid language: $language.</div>";
            $error = true;
            break;
        }
    }

    return !$error;
}
?>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>CV Generator</title>
    <script src="scripts.js"></script>
    <link href="styles.css" rel="stylesheet"/>
</head>
<body>
<?php
if ($_POST && validateFields()) {
	// This is generally a bad idea but there is nothing else in the page except the form data
	// so I will use it as a shortcut
	$_SESSION = $_POST;
	header("location: CVResult.php");
}
?>
<form method="post">
    <fieldset>
        <legend>Personal Information</legend>
        <input type="text" name="firstName" id="firstName" placeholder="First Name"/><br/>
        <input type="text" name="lastName" id="lastName" placeholder="Last Name"/><br/>
        <input type="text" name="email" id="email" placeholder="Email"/><br/>
        <input type="text" name="phoneNumber" id="phoneNumber" placeholder="Phone Number"/><br/>
        <input type="radio" name="sex" id="female" value="female">
        <label for="female">Female</label>
        <input type="radio" name="sex" id="male" value="male">
        <label for="male">Male</label><br/>
        <label for="birthDate">Birth Date</label><br/>
        <input type="text" name="birthDate" id="birthDate" placeholder="dd/mm/yyyy"/><br/>
        <label for="nationality">Nationality:</label><br/>
        <select name="nationality" id="nationality">
            <?php
            foreach ($nationalities as $key => $value) {
                echo "<option value=\"$key\"" . ($value == "Bulgarian" ? " selected" : "") . ">$value</option>";
            }
            ?>
        </select>
    </fieldset>
    <fieldset>
        <legend>Last Work Position</legend>
        <label for="companyName">Company Name</label>
        <input type="text" name="companyName" id="companyName"/><br/>
        <label for="from">From</label>
        <input type="text" name="from" id="from" placeholder="dd/mm/yyyy"/><br/>
        <label for="to">To</label>
        <input type="text" name="to" id="to" placeholder="dd/mm/yyyy"/>
    </fieldset>
    <fieldset>
        <legend>Computer Skills</legend>
        <label>Programming Languages</label><br/>

        <div id="programming-languages">
            <div id="prog-lang-1">
                <input type="text" name="programmingLanguages[]"/>
                <select name="programmingLanguageLevels[]">
                    <option>Beginner</option>
                    <option>Programmer</option>
                    <option>Advanced</option>
                    <option>Expert</option>
                    <option>Ninja</option>
                </select>
                <br/>
            </div>
        </div>
        <button id="remove-prog-lang">Remove Language</button>
        <button id="add-prog-lang">Add Language</button>
    </fieldset>
    <fieldset>
        <legend>Other Skills</legend>
        <label>Languages</label><br/>

        <div id="languages">
            <div id="lang-1">
                <input type="text" name="languages[]"/>
                <select name="comprehension[]">
                    <option selected disabled>-Comprehension-</option>
                    <option>beginner</option>
                    <option>intermediate</option>
                    <option>advanced</option>
                </select>
                <select name="reading[]">
                    <option selected disabled>-Reading-</option>
                    <option>beginner</option>
                    <option>intermediate</option>
                    <option>advanced</option>
                </select>
                <select name="writing[]">
                    <option selected disabled>-Writing-</option>
                    <option>beginner</option>
                    <option>intermediate</option>
                    <option>advanced</option>
                </select>
                <br/>
            </div>
        </div>
        <button id="remove-lang">Remove Language</button>
        <button id="add-lang">Add Language</button><br/>
        <label>Driver's License</label><br/>
        <input type="checkbox" name="licenses[]" id="driver-license-B" value="B"/>
        <label for="driver-license-B">B</label>
        <input type="checkbox" name="licenses[]" id="driver-license-A" value="A"/>
        <label for="driver-license-A">A</label>
        <input type="checkbox" name="licenses[]" id="driver-license-C" value="C"/>
        <label for="driver-license-C">C</label>
    </fieldset>
    <input type="submit" name="submit" value="Generate CV"/>
</form>
</body>
</html>