"""
Solution to project euler problem 17: number letter counts.
"""


def solution() -> int:
    """Return the total number of letters from 1 to 1000 in word form"""
    return hundred_to_thousand(first_hundred())


def one_to_nine() -> int:
    """Return the total number of letters from 0 to 9 in word form."""
    return 36


def ten_to_nineteen() -> int:
    """Return the total number of letters from 10 to 19 in word form."""
    return 70


def twenty_to_ninetynine() -> int:
    """Return the total number of letters from 20 to 99 in word form."""
    total_letters = one_to_nine() * 8  # the "suffix" of each number
    total_letters += (6 + 6 + 5 + 5 + 5 + 7 + 6 + 6) * 10  # the "prefix" of each number
    return total_letters


def first_hundred() -> int:
    """Return the total number of letters from 1 to 99 in word form."""
    return one_to_nine() + ten_to_nineteen() + twenty_to_ninetynine()


def remaining_hundred(prefix: int) -> int:
    """Return the total number of letters from prefix hundred to prefix hundred and ninety-nine in
    word form.

    Representation Invariants:
    - prefix in {x for x in range(1, 10)}
    """
    if prefix in {1, 2, 6}:
        return (3 * 99) + (3 * 99) + first_hundred()  # (len(prefix) * 99) + (len("and") * 99)
    elif prefix in {4, 5, 9}:
        return (4 * 99) + (3 * 99) + first_hundred()  # (len(prefix) * 99) + (len("and") * 99)
    else:  # prefix in {3, 7, 8}
        return (5 * 99) + (3 * 99) + first_hundred()  # (len(prefix) * 99) + (len("and") * 99)


def hundred_to_thousand(letters_so_far: int) -> int:
    """Return the total number of letters from 100 to 1000 in word form."""
    for i in range(1, 10):
        letters_so_far += remaining_hundred(i) + (len('hundred') * 99)

    # To account for the length of 100, 200, ..., 900, 1000 in word form:
    letters_so_far += 10 + 10 + 12 + 11 + 11 + 10 + 12 + 12 + 11 + 11
    return letters_so_far


if __name__ == '__main__':
    print(solution())
