def remove_words(input_string, sequence):
  result = list(filter(lambda word: sequence not in word, input_string.split()))
  return " ".join(result)


sample = "Однажды, в студабвеную зимнюю пору я из лесу вышел; был силабвьный мороз. Гляжу, поднимается медлеабвнно в гору лошадка, везущая хвоабвросту воз."

print (remove_words(sample, "абв"))