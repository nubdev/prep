configs ={
  :git => {
    :user => '20121001chicago',
    :remotes => potentially_change("remotes",__FILE__),
    :repo => 'prep' 
  }
}
configatron.configure_from_hash(configs)
